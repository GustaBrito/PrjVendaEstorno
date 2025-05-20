using VendaEstorno.code.Bll;
using VendaEstorno.code.Dal;
using System.Data;

namespace VendaEstorno
{
    public partial class frmPesquisaProdutos : Form
    {
        private readonly ProdutosDal produtosDal = new ProdutosDal();
        //private readonly produtosDto produto = new produtosDto();
        private readonly ProdutosBll produtosBll = new ProdutosBll();

        public frmPesquisaProdutos()
        {
            InitializeComponent();
            ConfigureDataGridView();
            PreencherComboBoxFiltros();
            CarregaGrid();
        }

        private void CarregaGrid()
        {
            try
            {
                DataTable table = produtosDal.GetProdutos();
                dgProduto.DataSource = table;
            }
            catch (Exception ex)
            {
                ShowError("Erro ao carregar dados.", ex);
            }
        }

        private void ShowError(string message, Exception ex = null)
        {
            MessageBox.Show($"{message} {ex?.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ConfigureDataGridView()
        {
            dgProduto.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgProduto.MultiSelect = false;
            dgProduto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void PreencherComboBoxFiltros()
        {
            cmbPesqProd.Items.Clear();
            cmbPesqProd.Items.Add("CODIGO DO PRODUTO");
            cmbPesqProd.Items.Add("DESCRICAO");
            cmbPesqProd.Items.Add("CODIGO DA MARCA");
            cmbPesqProd.Items.Add("MARCA");
            cmbPesqProd.Items.Add("QUANTIDADE EM ESTOQUE");
            cmbPesqProd.Items.Add("PRECO");
            cmbPesqProd.Items.Add("DATA DE VENCIMENTO");
            cmbPesqProd.Items.Add("TIPO DE REGISTRO");
            cmbPesqProd.SelectedIndex = -1; // Nenhum item selecionado por padrão
        }

        private void btnPesquisaProdNovo_Click(object sender, EventArgs e)
        {
            using (var frm = new frmCadastroProdutos())
            {
                frm.OnCadastroProdutoConcluido += CarregaGrid; // Atualiza o grid após cadastro
                frm.ShowDialog();
            }
        }
        
        private void btnPesquisaProd_Click(object sender, EventArgs e)
        {
            string Categoria = cmbPesqProd.SelectedItem?.ToString();
            string busca = txtPesqProd.Text.Trim();

            // Verifica se a categoria é válida e se a busca não está vazia
            if (string.IsNullOrEmpty(Categoria))
            {
                MessageBox.Show("Selecione uma categoria para pesquisar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            AtualizarGrid(Categoria, busca);
        }
        private void AtualizarGrid(string categoria, string busca)
        {
            try
            {
                DataTable dt;

                if (string.IsNullOrEmpty(busca))
                {
                    dt = produtosDal.GetProdutos();
                }
                else
                {
                    // Verifique se produtosDal não é nulo
                    if (produtosDal == null)
                    {
                        throw new InvalidOperationException("O objeto produtosDal não foi inicializado.");
                    }

                    // Consulta os produtos com o filtro
                    dt = produtosDal.ConsultarProdutosCmb(categoria, busca);
                }

                // Verifique se dt não é nulo antes de definir a fonte de dados
                if (dt != null)
                {
                    dgProduto.DataSource = dt; // Preenche a grid com os dados retornados
                }
                else
                {
                    MessageBox.Show("Nenhum dado retornado pela consulta.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao consultar dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnPesquisaProdAlterar_Click(object sender, EventArgs e)
        {
            if (dgProduto.SelectedRows.Count > 0)
            {
                var selectedRow = dgProduto.SelectedRows[0];
                var codProduto = selectedRow.Cells["CODPRODUTO"].Value.ToString();

                if (!string.IsNullOrEmpty(codProduto))
                {
                    var frm = new frmCadastroProdutos();
                    frm.OnCadastroProdutoConcluido += AtualizarDataGridView; // Atualiza o grid após alteração
                    frm.ConfigurarFormulario(codProduto);
                    frm.ShowDialog(); // Use ShowDialog() para garantir que o formulário de cadastro seja modal
                }
                else
                {
                    MessageBox.Show("O código do produto está vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Selecione um produto para alterar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void AtualizarDataGridView()
        {
            CarregarDadosNoDataGridView();
        }

        private void CarregarDadosNoDataGridView()
        {
            try
            {
                ProdutosDal produtosDal = new ProdutosDal(); // Instanciar a classe
                DataTable produtos = produtosDal.GetProdutos(); // Chamar o método
                if (produtos != null && produtos.Rows.Count > 0)
                {
                    dgProduto.DataSource = produtos;
                    dgProduto.Refresh();
                }
                else
                {
                    MessageBox.Show("Nenhum dado encontrado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar dados: {ex.Message}");
            }
        }
        private void btnPesquisaProdExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgProduto.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Nenhum cliente selecionado. Selecione um cliente para excluir.");
                    return;
                }

                int CodProduto = Convert.ToInt32(dgProduto.SelectedRows[0].Cells["CodProduto"].Value);

                var result = MessageBox.Show(
                    "Tem certeza de que deseja excluir este cliente?",
                    "Confirmação de Exclusão",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.No)
                {
                    return;
                }

                ProdutosDal produtosDal = new ProdutosDal();

                int rowsAffected = produtosDal.DeletarProduto(CodProduto);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Registro excluído com sucesso!");
                }
                else if (rowsAffected == 0)
                {
                    MessageBox.Show("Nenhuma linha foi afetada. Verifique se o código está correto.");
                }
                else
                {
                    MessageBox.Show("Erro ao excluir o registro.");
                }

                CarregaGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}");
            }
        }

        private void btnPesquisaProdCancelar_Click(object sender, EventArgs e)
        {
            cmbPesqProd.SelectedIndex = -1;
            txtPesqProd.Clear();
            CarregaGrid();
        }

        private void btnPesquisaProdVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AtualizaConfigTextBox(string categoria)
        {
            if (string.IsNullOrEmpty(categoria))
            {
                txtPesqProd.Clear();
                txtPesqProd.MaxLength = 0;
                txtPesqProd.KeyPress -= txtPesqProd_KeyPress;
                return;
            }

            txtPesqProd.Clear();
            txtPesqProd.KeyPress -= txtPesqProd_KeyPress;

            switch (categoria)
            {
                case "CODIGO DO PRODUTO":
                case "QUANTIDADE EM ESTOQUE":
                case "PRECO":
                case "DATA DE VENCIMENTO":
                case "CODIGO DA MARCA":
                    txtPesqProd.MaxLength = 10; // Ajuste conforme necessário
                    txtPesqProd.KeyPress += txtPesqProd_KeyPress;
                    break;
                case "MARCA":
                case "DESCRICAO":
                case "TIPO DE REGISTRO":
                    txtPesqProd.MaxLength = 100; // Ajuste conforme necessário
                    txtPesqProd.KeyPress += txtPesqProd_KeyPress;
                    break;
                default:
                    txtPesqProd.MaxLength = 0;
                    break;
            }
        }

        private int GetMaxLengthForCategory(string categoria)
        {
            return categoria switch
            {
                "CODIGO DO PRODUTO" => 5,
                "QUANTIDADE EM ESTOQUE" => 10,
                "PRECO" => 11,
                "DATA DE VENCIMENTO" => 10,
                "CODIGO DA MARCA" => 30,
                "MARCA" => 5,
                "DESCRICAO" => 100,
                "TIPO DE REGISTRO" => 1,

                _ => 0
            };
        }

        private void txtPesqProd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtPesqProd.MaxLength == 10)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '/' && e.KeyChar != '-')
                {
                    e.Handled = true;
                }
            }
            else if (txtPesqProd.MaxLength == 100)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void dgProduto_SelectionChanged(object sender, EventArgs e)
        {
            btnPesquisaProdAlterar.Enabled = dgProduto.SelectedRows.Count > 0;
            btnPesquisaProdExcluir.Enabled = dgProduto.SelectedRows.Count > 0;
        }

        private void cmbPesqProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedFilter = cmbPesqProd.SelectedItem?.ToString();
            AtualizaConfigTextBox(selectedFilter);
        }

        private void frmPesquisaProdutos_Load(object sender, EventArgs e)
        {
            CarregaGrid();
            PreencherComboBoxFiltros();
        }

        private void dgProduto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}