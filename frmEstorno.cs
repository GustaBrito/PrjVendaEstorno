using VendaEstorno.code.Dal;
using System.Data;

namespace VendaEstorno
{
    public partial class frmEstorno : Form
    {
        private readonly ProdutosDal produtosDal = new ProdutosDal();
        private readonly DataTable estornoDataTable = new DataTable();
        private readonly DataTable dataDataTable = new DataTable();

        public frmEstorno()
        {
            InitializeComponent();
            ConfigurarDataGrid();
            SetupDgEstorno();
            SetupDgDataEstorno();
        }

        private void ConfigurarDataGrid()
        {
            dgEstorno.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgEstorno.MultiSelect = false;
            dgEstorno.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnOkEstorno_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtCodVenda.Text, out int codVenda) && codVenda > 0)
            {
                var itensVenda = produtosDal.GetItensPorCodigoVenda(codVenda);

                if (itensVenda.Rows.Count > 0)
                {
                    estornoDataTable.Clear();

                    foreach (DataRow row in itensVenda.Rows)
                    {
                        estornoDataTable.Rows.Add(
                        row["codvenda"],
                        row["codproduto"],
                        row["descricao"],
                        row["qtdade"],
                        row["valor"]
                        );
                    }

                    dgEstorno.DataSource = estornoDataTable;
                }
                else
                {
                    MessageBox.Show("Nenhum item encontrado para esta venda.");
                }
            }
            else
            {
                MessageBox.Show("Insira um código de venda válido.");
            }
        }

        private void btnEstorno_Click(object sender, EventArgs e)
        {
            if (dgEstorno.Rows.Count == 0)
            {
                MessageBox.Show("Por favor, carregue os itens da venda antes de estornar.");
                return;
            }

            if (!int.TryParse(txtCodVenda.Text, out int codVenda))
            {
                MessageBox.Show("Código de venda inválido. Por favor, insira um número.");
                return;
            }

            bool codVendaExists = dgEstorno.Rows.Cast<DataGridViewRow>()
                .Any(row => Convert.ToInt32(row.Cells["Código da Venda"].Value) == codVenda);

            if (!codVendaExists)
            {
                MessageBox.Show("O código de venda não foi encontrado na lista.");
                return;
            }

            var result = MessageBox.Show(
                "Tem certeza de que deseja fazer o estorno nesse pedido de venda?",
                "Confirmação de Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.No)
                return;

            try
            {
                foreach (DataRow row in estornoDataTable.Rows)
                {
                    int codProduto = Convert.ToInt32(row["Código do Produto"]);
                    int quantidadeEstorno = Convert.ToInt32(row["Quantidade"]);

                    produtosDal.AtualizaQuantidadeProduto(codProduto, quantidadeEstorno);
                }

                produtosDal.DeletaVendaEstorno(codVenda);

                MessageBox.Show("Estorno realizado com sucesso!");
                estornoDataTable.Clear();
                dataDataTable.Clear();
                txtCodVenda.Clear();
            }
            catch (Exception ex)
            {
                ShowError("Erro ao realizar estorno.", ex);
            }
        }

        private void ShowError(string message, Exception ex = null)
        {
            MessageBox.Show(message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void SetupDgEstorno()
        {
            estornoDataTable.Columns.Add("Código da Venda", typeof(int));
            estornoDataTable.Columns.Add("Código do Produto", typeof(int));
            estornoDataTable.Columns.Add("Descrição", typeof(string));
            estornoDataTable.Columns.Add("Quantidade", typeof(float));
            estornoDataTable.Columns.Add("Valor Unitário", typeof(float));

            dgEstorno.DataSource = estornoDataTable;
        }
        private void SetupDgDataEstorno()
        {
            dataDataTable.Columns.Clear();
            dataDataTable.Columns.Add("Código da Venda", typeof(int));
            dataDataTable.Columns.Add("Data da Venda", typeof(DateTime));

            dgData.DataSource = dataDataTable;
        }
        private void btnVoltarEstorno_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancelarEstorno_Click(object sender, EventArgs e)
        {
            estornoDataTable.Clear();
            txtCodVenda.Clear();
        }
        private void btnEstornoData_Click(object sender, EventArgs e)
        {

            if(string.IsNullOrEmpty(mskInicialEstorno.Text.Trim()) || string.IsNullOrEmpty(mskFinalEstorno.Text.Trim()))
            {
                MessageBox.Show("Preencha as datas antes de continuar");
                return;
            }
            if (!DateTime.TryParse(mskInicialEstorno.Text, out DateTime dataInicio))
            {
                MessageBox.Show("Preencha a data inicial com uma data válida");
                mskInicialEstorno.Focus();
                return;
            }

            if (!DateTime.TryParse(mskFinalEstorno.Text, out DateTime dataFim))
            {
                MessageBox.Show("Preencha a data final com uma data válida");
                mskFinalEstorno.Focus();
                return;
            }


            if (dataInicio.Date <= dataFim.Date)
            {
                try
                {
                    var vendasData = produtosDal.GetVendasEntreDatas(dataInicio.Date, dataFim.Date);

                    if (vendasData.Rows.Count > 0)
                    {
                        dataDataTable.Clear();

                        foreach (DataRow row in vendasData.Rows)
                        {
                            // Certifique-se de que está adicionando exatamente duas colunas
                            dataDataTable.Rows.Add(
                                Convert.ToInt32(row["codvenda"]),   // Código da Venda
                                Convert.ToDateTime(row["dataVenda"]) // Data da Venda
                            );
                        }

                        dgData.DataSource = dataDataTable;
                    }
                    else
                    {
                        MessageBox.Show("Nenhuma venda encontrada entre as datas selecionadas.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao buscar vendas: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("A data de início deve ser anterior ou igual à data de fim.");
            }
        }

        private void CarregarItensVenda(int codVenda)
        {
            var itensVenda = produtosDal.GetItensPorCodigoVenda(codVenda);

            if (itensVenda.Rows.Count > 0)
            {
                estornoDataTable.Clear();

                foreach (DataRow row in itensVenda.Rows)
                {

                    estornoDataTable.Rows.Add(
                        row["codvenda"],
                        row["codproduto"],
                        row["descricao"],
                        row["qtdade"],
                        row["valor"]
                    );
                }

                dgEstorno.DataSource = estornoDataTable;
            }
            else
            {
                MessageBox.Show("Nenhum item encontrado para esta venda.");
            }
        }

        private void dgData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int codVenda = Convert.ToInt32(dgData.Rows[e.RowIndex].Cells["Código da Venda"].Value);
                txtCodVenda.Text = codVenda.ToString();

                CarregarItensVenda(codVenda);
            }
            else
            {
                MessageBox.Show("Selecione uma linha das datas para continuar");
            }
        }

    }
}