using VendaEstorno.code.Bll;
using VendaEstorno.code.Dal;

namespace VendaEstorno
{
    public partial class frmCadastroMarca : Form
    {
        private readonly MarcasBll _marcasBll = new MarcasBll();
        private readonly ProdutosDal produtosDal = new ProdutosDal();
        private bool _isUpdateMode;
        private string _marcaCodigo;
        public event Action OnCadastroProdutoConcluido;

        public frmCadastroMarca()
        {
            InitializeComponent();
        }

        public void ConfigurarFormulario(int marcaCodigo)
        {
            if (marcaCodigo <= 0)
            {
                // Configuração para Novo Registro
                _isUpdateMode = false;
                txtMarcaCodigo.Enabled = false; // Desabilita o campo código para novos registros
                LimpaCampos();
            }
            else
            {
                // Configuração para Edição
                _isUpdateMode = true;
                _marcaCodigo = marcaCodigo.ToString(); // Armazena o código como string se necessário

                // Certifique-se de que o método ObterMarcaPorCodigo aceita int
                var dataTable = _marcasBll.ObterMarcaPorCodigo(marcaCodigo);

                if (dataTable.Rows.Count > 0)
                {
                    var row = dataTable.Rows[0];
                    txtMarcaCodigo.Text = row["CODMARCA"].ToString();
                    txtMarcaDescricao.Text = row["DESCRICAO"].ToString();
                }
                else
                {
                    // Caso a marca não seja encontrada, você pode querer tratar o erro
                    MessageBox.Show("Marca não encontrada.");
                    LimpaCampos();
                    return;
                }

                txtMarcaCodigo.Enabled = false; // Código não pode ser alterado na edição
            }
        }

        private void btnMarcaGravar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMarcaDescricao.Text))
                {
                    MessageBox.Show("Preencha a descrição da marca");
                    return;
                }
                string descricao = txtMarcaDescricao.Text;

                if (string.IsNullOrWhiteSpace(descricao))
                {
                    MessageBox.Show("A descrição não pode estar vazia.");
                    txtMarcaDescricao.Focus();
                    return;
                }
                if (produtosDal.DescricaoDuplicadaMarca(descricao))
                {
                    MessageBox.Show("Já existe um produto com esta descrição.");
                    txtMarcaDescricao.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtMarcaCodigo.Text) || !int.TryParse(txtMarcaCodigo.Text, out int codigoExistMarca))
                {
                    int novoCodigo = produtosDal.InserirMarca(descricao);
                    if (novoCodigo > 0)
                    {
                        MessageBox.Show("Gravado com sucesso!");
                        txtMarcaCodigo.Text = novoCodigo.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao gravar o registro.");
                    }
                }
                else
                {
                    int resultado = produtosDal.AtualizarMarca(codigoExistMarca, descricao);
                    if (resultado > 0)
                    {
                        MessageBox.Show("Alterado com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Erro ao alterar o registro.");
                    }
                }

                // Notify completion and clean up
                OnCadastroProdutoConcluido?.Invoke();
                LimpaCampos();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}");
            }
        }

        private void btnMarcaCancelar_Click(object sender, EventArgs e)
        {
            LimpaCampos();
        }

        private void btnMarcaVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LimpaCampos()
        {
            txtMarcaCodigo.Clear();
            txtMarcaDescricao.Clear();
            txtMarcaCodigo.Enabled = false; // Habilita para novos registros, desabilita para edição
        }

        private void ShowError(string message)
        {
            MessageBox.Show(message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}