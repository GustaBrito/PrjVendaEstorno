using VendaEstorno.code.Dal;
using System.Data;
using System.Text;

namespace VendaEstorno
{
    public partial class frmImportarArquivo : Form
    {
        private DataTable dtProdutos = new DataTable();
        private readonly ProdutosDal produtosDal = new ProdutosDal();

        public frmImportarArquivo()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {
            dtProdutos.Columns.Add("CodProduto", typeof(string));
            dtProdutos.Columns.Add("Descricao", typeof(string));
            dtProdutos.Columns.Add("Status", typeof(string));
            dgImportar.DataSource = dtProdutos;

            dgImportar.Columns[0].HeaderText = "Código do Produto";
            dgImportar.Columns[1].HeaderText = "Descrição do Produto";
            dgImportar.Columns[2].HeaderText = "Status";
        }

        private void btnLocalizarArquivo_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text files (*.txt)|*.txt";
                openFileDialog.Title = "Selecionar Arquivo de Produtos";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    txtImportarArquivo.Text = Path.GetFileName(filePath);
                    ArquivoNoGrid(filePath);
                }
            }
        }

        private void ArquivoNoGrid(string filePath)
        {
            dtProdutos.Clear();
            try
            {
                using (StreamReader sr = new StreamReader(filePath, Encoding.Default))
                {
                    string line;
                    HashSet<string> produtos = new HashSet<string>();

                    int totalLines = File.ReadAllLines(filePath).Length;
                    progressBar1.Minimum = 0;
                    progressBar1.Maximum = totalLines;
                    progressBar1.Value = 0;

                    while ((line = sr.ReadLine()) != null)
                    {
                        if (!string.IsNullOrWhiteSpace(line))
                        {
                            string[] columns = line.Split('|');

                            string codProduto = columns.Length > 0 ? columns[0].Trim() : string.Empty;
                            string descricao = columns.Length > 1 ? columns[1].Trim() : string.Empty;
                            string status;

                            if (!int.TryParse(codProduto, out int cod) || cod <= 0)
                            {
                                status = "FALHA";
                            }
                            else if (string.IsNullOrWhiteSpace(descricao))
                            {
                                status = "FALHA";
                            }
                            else if (produtosDal.ProdutoExiste(cod))
                            {
                                status = "DUPLICADA";
                            }
                            else if (!produtos.Add(codProduto))
                            {
                                status = "DUPLICADA";
                            }
                            else
                            {
                                status = "OK";
                            }

                            dtProdutos.Rows.Add(codProduto, descricao, status);
                        }
                        progressBar1.Value++;
                    }
                }


                AcionarBotao();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao ler o arquivo: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AcionarBotao()
        {
            bool hasOkItems = dtProdutos.AsEnumerable().Any(row => row.Field<string>("Status") == "OK");
            btnImportarArquivo.Enabled = hasOkItems;
        }

        private void btnImportarArquivo_Click(object sender, EventArgs e)
        {
            int totalLines = dtProdutos.Rows.Count;
            int importedLines = 0;
            int falhas = 0;
            int duplicadas = 0;

            if (totalLines == 0)
            {
                MessageBox.Show("Nenhuma linha para importar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            progressBarImportacao.Minimum = 0;
            progressBarImportacao.Maximum = totalLines;
            progressBarImportacao.Value = 0;

            List<string> errorMessages = new List<string>();

            try
            {
                foreach (DataRow row in dtProdutos.Rows)
                {
                    string status = row["Status"].ToString();
                    string codProdutoStr = row["CodProduto"].ToString();
                    string descricao = row["Descricao"].ToString();

                    if (status.Equals("OK", StringComparison.OrdinalIgnoreCase))
                    {
                        if (int.TryParse(codProdutoStr, out int codProduto) && codProduto > 0)
                        {
                            if (produtosDal.ProdutoExiste(codProduto))
                            {
                                row["Status"] = "DUPLICADA";
                                duplicadas++;
                            }
                            else
                            {
                                int resultado = produtosDal.ImportarProduto(codProduto, descricao);
                                if (resultado > 0) 
                                {
                                    importedLines++;
                                    row["Status"] = "OK"; 
                                }
                                else
                                {
                                    row["Status"] = "FALHA";
                                    falhas++;
                                }
                            }
                        }
                        else
                        {
                            row["Status"] = "FALHA";
                            falhas++;
                            errorMessages.Add($"Código do Produto inválido: {codProdutoStr}. Deve ser um número e maior que 0.");
                        }
                    }

                    progressBarImportacao.Value++;
                    lblProgressoImportacao.Text = $"{(progressBarImportacao.Value * 100) / totalLines}%";
                    Application.DoEvents(); 
                }

                lblResumoImportacao.Text = $"Qtdade de linhas do arquivo:\n{totalLines}\nQtdade de linhas importadas:\n{importedLines}"/*\nQtdade de produtos duplicados:\n{duplicadas}\nTotal de falhas:\n{falhas}"*/;

                if (errorMessages.Count > 0)
                {
                    MessageBox.Show(string.Join("\n", errorMessages), "Resumo da Importação - Erros", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                MessageBox.Show($"Importação concluída!", "Resumo da Importação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao importar dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelarArquivo_Click(object sender, EventArgs e)
        {
            dtProdutos.Clear();
            txtImportarArquivo.Clear();
            progressBarImportacao.Value = 0;
            progressBar1.Value = 0;

            lblProgressoImportacao.Text = "0%";
            lblResumoImportacao.Text = "Resumo da Importação:\n Nenhuma linha importada.";

            MessageBox.Show("Importação cancelada. Todos os dados foram limpos.", "Cancelamento", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnVoltarArquivo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}