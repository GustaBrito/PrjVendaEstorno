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
    public partial class frmMenu : Form
    {
        string Categoria;

        public frmMenu()
        {
            InitializeComponent();
        }
        private void btnProdutos_Click(object sender, EventArgs e)
        {
            Categoria = "Produto";
            ChamaForm<frmPesquisaProdutos>(Categoria);
        }

        private void btnVenda_Click(object sender, EventArgs e)
        {
            Categoria = "Venda";
            ChamaForm<frmVenda>(Categoria);
        }

        private void btnEstorno_Click(object sender, EventArgs e)
        {
            Categoria = "Estorno";
            ChamaForm<frmEstorno>(Categoria);
        }
        private void btnImportacao_Click(object sender, EventArgs e)
        {
            Categoria = "Importacao";
            ChamaForm<frmImportarArquivo>(Categoria);
        }
        private void btnExportacao_Click(object sender, EventArgs e)
        {
            Categoria = "Exportacao";
            ChamaForm<frmExportarArquivo>(Categoria);
        }
        private void btnMarca_Click(object sender, EventArgs e)
        {
            Categoria = "Marca";
            ChamaForm<frmPesquisaMarca>(Categoria);
        }
        private void ChamaForm<Forms>(string Categoria) where Forms : Form, new()
        {
            Form formulario;
            formulario = pTelas.Controls.OfType<Forms>().FirstOrDefault();

            if (formulario == null)
            {
                formulario = new Forms();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;

                pTelas.Controls.Add(formulario);
                pTelas.Tag = formulario;

                formulario.Show();
                formulario.BringToFront();

            }
            else
            {
                if (formulario.WindowState == FormWindowState.Minimized)
                {
                    formulario.WindowState = FormWindowState.Normal;
                }
                formulario.BringToFront();
            }
        }

        private void btnMenuSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimiza_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void btnMaximiza_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }


        private void frmMenu_Load(object sender, EventArgs e)
        {
            btnMinimiza.Visible = false;
            btnMaximiza.Visible = false;
        }
    }
}
