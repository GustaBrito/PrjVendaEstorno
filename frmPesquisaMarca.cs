using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VendaEstorno.code.Dto;
using VendaEstorno.code.Dal;
using VendaEstorno.code.Bll;
using System.Data.SQLite;
using System.IO;

namespace VendaEstorno
{
    public partial class frmPesquisaMarca : Form
    {
        private readonly MarcasBll _marcasBll = new MarcasBll();

        public frmPesquisaMarca()
        {
            InitializeComponent();
            CarregarMarcas();
            ConfigureDataGridView();
        }

        private void ConfigureDataGridView()
        {
            dgMarca.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgMarca.MultiSelect = false;
            dgMarca.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void CarregarMarcas(string descricao = "")
        {
            try
            {
                DataTable dataTable = _marcasBll.ObterMarcas(descricao);
                dgMarca.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                ShowError("Erro ao carregar marcas.", ex);
            }
        }

        private void ShowError(string message, Exception ex = null)
        {
            MessageBox.Show($"{message} {ex?.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnPesqProdMarca_Click(object sender, EventArgs e)
        {
            var descricao = txtPesquisaProdMarca.Text.Trim();
            CarregarMarcas(descricao);
        }

        private void btnPesqProdMarcaNovo_Click(object sender, EventArgs e)
        {
            using (var frmCadastroMarca = new frmCadastroMarca())
            {
                frmCadastroMarca.ShowDialog();
                CarregarMarcas(); // Recarrega a lista após adicionar uma nova marca
            }
        }

        private void btnPesqProdMarcaAlterar_Click(object sender, EventArgs e)
        {
            if (dgMarca.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um registro para alterar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tente garantir que o valor na célula é uma string.
            var marcaCodigo = dgMarca.SelectedRows[0].Cells["CODMARCA"].Value.ToString();

            // Verifique se o valor não é nulo ou vazio.
            if (string.IsNullOrEmpty(marcaCodigo))
            {
                MessageBox.Show("Código da marca inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var frmCadastroMarca = new frmCadastroMarca())
            {
                // Passar o valor correto para o ConfigurarFormulario
                frmCadastroMarca.ConfigurarFormulario(int.Parse(marcaCodigo));
                frmCadastroMarca.ShowDialog();
                CarregarMarcas(); // Recarrega a lista após alterar uma marca
            }
        }

        private void btnPesqProdMarcaExcluir_Click(object sender, EventArgs e)
        {
            if (dgMarca.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um registro para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var marcaCodigo = dgMarca.SelectedRows[0].Cells["CODMARCA"].Value.ToString();
            var result = MessageBox.Show("Tem certeza que deseja excluir o registro selecionado?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    _marcasBll.ExcluirMarca(marcaCodigo);
                    MessageBox.Show("Marca excluída com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregarMarcas(); // Recarrega a lista após exclusão
                }
                catch (Exception ex)
                {
                    ShowError("Erro ao excluir a marca.", ex);
                }
            }
        }

        private void btnPesqProdMarcaCancelar_Click(object sender, EventArgs e)
        {
            txtPesquisaProdMarca.Clear();
            CarregarMarcas(); // Recarrega a lista completa
        }

        private void btnPesqProdMarcaVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}