using VendaEstorno.code.Dal;

namespace VendaEstorno
{
    public partial class frmCadastroProdutos : Form
    {
        private readonly ProdutosDal produtosDal = new ProdutosDal();
        private bool _isUpdateMode;
        public event Action OnCadastroProdutoConcluido;
        DateTime DataAtual = DateTime.Today.Date;

        public frmCadastroProdutos()
        {
            InitializeComponent();
            CarregarMarcas();
        }

        public void ConfigurarFormulario(string codProduto)
        {
            if (string.IsNullOrEmpty(codProduto))
                return;

            try
            {
                var dataTable = produtosDal.GetProdutoByCodigo(codProduto);

                if (dataTable.Rows.Count > 0)
                {
                    var row = dataTable.Rows[0];
                    txtCadastroProd.Text = row["CODPRODUTO"].ToString();
                    txtDescricaoProd.Text = row["DESCRICAO"].ToString();
                    txtQtdEstoque.Text = row["QTDESTOQUE"].ToString();
                    txtPreco.Text = row["PRECO"].ToString();
                    mskDataVencto.Text = row["DATAVENCTO"].ToString();
                    txtTipoRegistro.Text = (row["TIPOREGISTRO"].ToString());

                    cmbMarca.SelectedValue = row["CODMARCA"];
                }

                txtCadastroProd.Enabled = false;
                _isUpdateMode = true;
            }
            catch (Exception ex)
            {
                ShowError("Erro ao configurar o formulário.", ex);
            }
        }

        private void CarregarMarcas()
        {
            try
            {
                var dataTable = produtosDal.GetMarcas();
                cmbMarca.DataSource = dataTable;
                cmbMarca.DisplayMember = "DESCRICAO";
                cmbMarca.ValueMember = "CODMARCA";
            }
            catch (Exception ex)
            {
                ShowError("Erro ao carregar marcas.", ex);
            }
        }

        private bool ValidaCampos()
        {
            // Validação do CodProduto
            if (!string.IsNullOrWhiteSpace(txtCadastroProd.Text) && !int.TryParse(txtCadastroProd.Text, out int CodProduto))
            {
                MessageBox.Show("Código inválido.");
                txtCadastroProd.Focus();
                return false;
            }

            // Validação da descrição
            if (string.IsNullOrWhiteSpace(txtDescricaoProd.Text))
            {
                MessageBox.Show("A descrição não pode estar vazio.");
                txtDescricaoProd.Focus();
                return false;
            }

            // Validação da Quantidade de estoque
            if (!int.TryParse(txtQtdEstoque.Text, out int QTDESTOQUE) || QTDESTOQUE < 0)
            {
                MessageBox.Show("Quantidade de estoque deve ser um número válido maior que 0.");
                txtQtdEstoque.Focus();
                return false;
            }
            // Validação do preço
            if (!int.TryParse(txtPreco.Text, out int preco) || preco < 0)
            {
                MessageBox.Show("Preço deve ser um número válido maior que 0.");
                txtQtdEstoque.Focus();
                return false;
            }
            if (!DateTime.TryParse(mskDataVencto.Text, out DateTime dt))
            {
                MessageBox.Show("Data deve ser válida.");
                mskDataVencto.Focus();
                return false;
            }
            // Validação do TipoRegistro
            if (string.IsNullOrWhiteSpace(txtTipoRegistro.Text))
            {
                MessageBox.Show("O tipo do registro não pode estar vazio.");
                txtTipoRegistro.Focus();
                return false;
            }
            // Validação da Marca
            if (cmbMarca.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecione uma Marca.");
                cmbMarca.Focus();
                return false;
            }

            return true;
        }

        private void btnCadProdCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidaCampos())
                {
                    return;
                }

                if (!float.TryParse(txtPreco.Text, out float preco) || preco < 0)
                {
                    MessageBox.Show("Preço deve ser um número válido maior que 0.");
                    txtPreco.Text = string.Empty;
                    txtPreco.Focus();
                    return;
                }

                string QtdEstoqueText = txtQtdEstoque.Text.Trim();
                if (!int.TryParse(QtdEstoqueText, out int qtdEstoque) || qtdEstoque < 0)
                {
                    MessageBox.Show("A quantidade de estoque deve ser um número válido maior ou igual a 0.");
                    txtQtdEstoque.Text = string.Empty;
                    txtQtdEstoque.Focus();
                    return;
                }

                if (!int.TryParse(cmbMarca.SelectedValue?.ToString(), out int codMarca))
                {
                    MessageBox.Show("Selecione uma marca válida.");
                    cmbMarca.Focus();
                    return;
                }

                string descricao = txtDescricaoProd.Text;
                DateTime datavencto = Convert.ToDateTime(mskDataVencto.Text.Trim());
                string tiporegistro = txtTipoRegistro.Text;

                int resultado;

                if (string.IsNullOrWhiteSpace(txtCadastroProd.Text) || !int.TryParse(txtCadastroProd.Text, out int codigoExistente))
                {
                    int novoCodigo = produtosDal.InsertProduto(descricao, qtdEstoque, preco, datavencto, codMarca, tiporegistro);
                    if (produtosDal.DescricaoDuplicada(descricao))
                    {
                        MessageBox.Show("Já existe um produto com esta descrição.");
                        txtDescricaoProd.Focus();
                        return;
                    }
                    if (novoCodigo > 0)
                    {
                        MessageBox.Show("Gravado com sucesso!");
                        txtCadastroProd.Text = novoCodigo.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao gravar o registro.");
                    }
                }
                else
                {
                    // Alterar registro existente
                    resultado = produtosDal.UpdateProduto(codigoExistente, descricao, qtdEstoque, preco, datavencto, codMarca, tiporegistro);
                    if (resultado > 0)
                    {
                        MessageBox.Show("Alterado com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Erro ao alterar o registro.");
                    }
                }

                OnCadastroProdutoConcluido?.Invoke();
                LimpaCampos();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}");
            }
        }

        private void LimpaCampos()
        {
            txtDescricaoProd.Clear();
            txtPreco.Clear();
            txtQtdEstoque.Clear();
            mskDataVencto.Text = DataAtual.ToString();
            txtTipoRegistro.Clear();
            txtCadastroProd.Clear();
            cmbMarca.SelectedIndex = -1;

            txtCadastroProd.Enabled = false; // O campo não deve ser editável
            _isUpdateMode = false;
        }

        private void btnCadProdCancelar_Click(object sender, EventArgs e)
        {
            LimpaCampos();
        }

        private void btnCadProdVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ShowError(string message, Exception ex = null)
        {
            MessageBox.Show(message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            // Opcional: Log do erro
            if (ex != null)
            {
                // Log do erro, se necessário
            }
        }

        private void txtQtdEstoque_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite somente dígitos e controle (como backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void txtTipoRegistro_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite somente letras "m e M" e "i e I"
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (e.KeyChar != 'M' && e.KeyChar != 'I' && e.KeyChar != 'm' && e.KeyChar != 'i')
            {
                e.Handled = true;
            }
        }

        private void cmbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}