using VendaEstorno.code.Dal;
using VendaEstorno.code.Dto;
using System.Data;

namespace VendaEstorno
{
    public partial class frmVenda : Form
    {
        private readonly ProdutosDal produtosDal = new ProdutosDal();
        private readonly DataTable vendaDataTable = new DataTable();
        public event Action OnCadastroProdutoConcluido;

        public frmVenda()
        {

            InitializeComponent();
            CarregarProdutosVenda();
            SetupDgVenda();
            ConfigurarDataGrid();
            cmbProdutoVenda.SelectedIndexChanged += cmbProdutoVenda_SelectedIndexChanged_1;
        }
        private void cmbProdutoVenda_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbProdutoVenda.SelectedItem is DataRowView selectedRow)
            {
                int codProduto = Convert.ToInt32(selectedRow["CODPRODUTO"]);
                var produto = produtosDal.ProdPorCodVenda(codProduto);
                if (produto != null)
                {
                    lblEstoqueVenda.Text = ("Disponivel: " + produto.QtdEstoque.ToString());
                    txtValorVenda.Text = produto.Preco.ToString("");
                }
            }
        }
        private void ConfigurarDataGrid()
        {
            dgVenda.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgVenda.MultiSelect = false;
            dgVenda.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void SetupDgVenda()
        {
            vendaDataTable.Columns.Add("Código do Produto", typeof(int));
            vendaDataTable.Columns.Add("Descrição", typeof(string));
            vendaDataTable.Columns.Add("Quantidade", typeof(float));
            vendaDataTable.Columns.Add("Quantidade em Estoque", typeof(float));
            vendaDataTable.Columns.Add("Valor Unitário", typeof(float));

            dgVenda.DataSource = vendaDataTable;
        }
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (!ValidaCamposVenda())
                return;

            int codProduto = Convert.ToInt32(cmbProdutoVenda.SelectedValue);
            string descricao = cmbProdutoVenda.Text;
            int qtdade = int.Parse(txtQtdVenda.Text);
            int qtdEstoque = produtosDal.GetEstoqueProduto(codProduto);

            if (qtdEstoque < qtdade)
            {
                MessageBox.Show("Quantidade em estoque insuficiente.");
                return;
            }

            DataRow[] existingRows = vendaDataTable.Select($"[Código do Produto] = {codProduto}");
            if (existingRows.Length > 0)
            {
                float quantidadeAtual = Convert.ToSingle(existingRows[0]["Quantidade"]);
                if (quantidadeAtual + qtdade > qtdEstoque)
                {
                    MessageBox.Show("A quantidade total excede o estoque disponível.");
                    return;
                }

                existingRows[0]["Quantidade"] = quantidadeAtual + qtdade;
                AtualizarEstoqueVenda(codProduto, qtdade);
            }
            else
            {
                float valor = float.Parse(txtValorVenda.Text);
                vendaDataTable.Rows.Add(codProduto, descricao, qtdade, qtdEstoque, valor);
            }

            LimpaCamposVenda();
        }

        private void AtualizarEstoqueVenda(int codProduto, int qtdade)
        {
            var produto = produtosDal.ProdPorCodVenda(codProduto);
            if (produto != null)
            {
                int novoEstoque = produto.QtdEstoque - qtdade;
                lblEstoqueVenda.Text = "Disponível: " + novoEstoque.ToString();
            }
        }

        private void CarregarProdutosVenda()
        {
            try
            {
                var dataTable = produtosDal.GetProdutos();
                cmbProdutoVenda.DataSource = dataTable;
                cmbProdutoVenda.DisplayMember = "DESCRICAO";
                cmbProdutoVenda.ValueMember = "CODPRODUTO";
            }
            catch (Exception ex)
            {
                ShowError("Erro ao carregar produtos.", ex);
            }
        }

        private void ShowError(string message, Exception ex = null)
        {
            MessageBox.Show(message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool ValidaCamposVenda()
        {
            if (cmbProdutoVenda.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecione um produto.");
                return false;
            }

            if (!int.TryParse(txtQtdVenda.Text, out int qtd) || qtd <= 0)
            {
                MessageBox.Show("Quantidade deve ser um número válido maior que 0.");
                txtQtdVenda.Focus();
                return false;
            }

            if (!float.TryParse(txtValorVenda.Text, out float valor) || valor <= 0)
            {
                MessageBox.Show("Valor deve ser um número válido maior que 0.");
                txtValorVenda.Focus();
                return false;
            }

            return true;
        }

        private void btnGravarVenda_Click(object sender, EventArgs e)
        {
            if (vendaDataTable.Rows.Count == 0)
            {
                MessageBox.Show("Por favor, adicione produtos ao grid antes de gravar a venda.");
                return;
            }

            try
            {
                int codVenda = produtosDal.GerarCodVenda();
                DateTime datavenda = DateTime.Now;
                var itensVenda = new List<VendaItem>();

                foreach (DataRow row in vendaDataTable.Rows)
                {
                    int codProduto = (int)row["Código do Produto"];
                    float qtdade = (float)row["Quantidade"];
                    float valor = (float)row["Valor Unitário"];

                    itensVenda.Add(new VendaItem
                    {
                        CodProduto = codProduto,
                        Qtdade = qtdade,
                        Valor = valor
                    });
                }

                produtosDal.ProcessarVenda(codVenda, datavenda, itensVenda);

                MessageBox.Show("Venda gravada com sucesso!");
                LimpaCamposVenda();
                vendaDataTable.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}");
            }
        }

        private void btnExcluirVenda_Click(object sender, EventArgs e)
        {
            if (dgVenda.SelectedRows.Count > 0)
            {
                var result = MessageBox.Show(
                    "Tem certeza de que deseja excluir este pedido de venda?",
                    "Confirmação de Exclusão",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.No)
                    return;

                foreach (DataGridViewRow row in dgVenda.SelectedRows)
                {
                    dgVenda.Rows.Remove(row);
                }
            }
            else
            {
                MessageBox.Show("Selecione uma linha para excluir.");
            }
        }

        private void btnCancelarVenda_Click(object sender, EventArgs e)
        {
            vendaDataTable.Clear();
            LimpaCamposVenda();
        }

        private void LimpaCamposVenda()
        {
            lblEstoqueVenda.Text = ("");
            txtQtdVenda.Clear();
            txtValorVenda.Clear();
            cmbProdutoVenda.SelectedIndex = -1;
        }

        private void btnVoltarVenda_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtQtdVenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtValorVenda_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }
    }
}