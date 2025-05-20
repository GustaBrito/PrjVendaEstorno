using VendaEstorno.code.Dal;
using System.Data;
using System.Text;

namespace VendaEstorno
{
    public partial class frmExportarArquivo : Form
    {
        private string selectedDirectory = string.Empty;
        private readonly ProdutosDal produtosDal = new ProdutosDal();

        public frmExportarArquivo()
        {
            InitializeComponent();
        }

        private void btnLocalizarExpArquivo_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.Description = "Selecione o diretório para salvar o arquivo";
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedDirectory = folderBrowserDialog.SelectedPath;
                    txtExportarArquivo.Text = selectedDirectory;
                }
            }
        }

        private void btnExportarArquivo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(selectedDirectory))
            {
                MessageBox.Show("Por favor, selecione um diretório antes de exportar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string filePath = Path.Combine(selectedDirectory, "Produtos.txt");
            int totalRows = 0;
            int exportedRows = 0;

            try
            {
                DataTable dtProdutos = produtosDal.GetProdutos();

                // Configura a ProgressBar
                progressBarExportacao.Minimum = 0;
                progressBarExportacao.Maximum = dtProdutos.Rows.Count;
                progressBarExportacao.Value = 0;
                progressBarExportacao.Step = 1;

                using (StreamWriter writer = new StreamWriter(filePath, false, Encoding.Default))
                {
                    // Escreve os cabeçalhos das colunas
                    writer.WriteLine("Código do Produto | Descrição | Quantidade em Estoque | Preço | Data de Vencimento | Código da Marca | Tipo de Registro");

                    foreach (DataRow row in dtProdutos.Rows)
                    {
                        string codProduto = row["codproduto"].ToString();
                        string descricao = row["descricao"].ToString();
                        string qtdEstoque = row["qtdEstoque"].ToString();
                        string preco = row["preco"].ToString();
                        string dataVencto = row["dataVencto"].ToString();
                        string codMarca = row["codMarca"].ToString();
                        string tipoRegistro = row["tipoRegistro"].ToString() == "M" ? "MANUAL" :
                                              row["tipoRegistro"].ToString() == "I" ? "IMPORTADO" :
                                              ""; // Transformação do tipoRegistro

                        writer.WriteLine($"{codProduto} | {descricao} | {qtdEstoque} | {preco} | {dataVencto} | {codMarca} | {tipoRegistro}");
                        totalRows++;
                        exportedRows++;

                        // Atualiza a ProgressBar
                        progressBarExportacao.PerformStep();
                        lblProgressoExportacao.Text = $"{(progressBarExportacao.Value * 100) / dtProdutos.Rows.Count}%";
                        Application.DoEvents(); // Permite que a interface gráfica atualize durante o loop
                    }
                }

                MessageBox.Show($"Exportação concluída.\nQtdade de linhas da tabela TBLPRODUTOS: {totalRows}\nQtdade de linhas exportadas: {exportedRows}", "Concluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao exportar dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelarExpArquivo_Click(object sender, EventArgs e)
        {
            selectedDirectory = string.Empty;
            txtExportarArquivo.Clear();
            progressBarExportacao.Value = 0;
            lblProgressoExportacao.Text = "0%";
        }

        private void btnVoltarExpArquivo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}