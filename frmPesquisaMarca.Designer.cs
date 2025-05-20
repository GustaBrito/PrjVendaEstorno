namespace VendaEstorno
{
    partial class frmPesquisaMarca
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            btnPesqProdMarcaVoltar = new Button();
            btnPesqProdMarcaCancelar = new Button();
            btnPesqProdMarcaExcluir = new Button();
            btnPesqProdMarcaAlterar = new Button();
            btnPesqProdMarcaNovo = new Button();
            dgMarca = new DataGridView();
            btnPesqProdMarca = new Button();
            txtPesquisaProdMarca = new TextBox();
            lblPesqProdMarca = new Label();
            ((System.ComponentModel.ISupportInitialize)dgMarca).BeginInit();
            SuspendLayout();
            // 
            // btnPesqProdMarcaVoltar
            // 
            btnPesqProdMarcaVoltar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnPesqProdMarcaVoltar.Location = new Point(1442, 760);
            btnPesqProdMarcaVoltar.Name = "btnPesqProdMarcaVoltar";
            btnPesqProdMarcaVoltar.Size = new Size(128, 45);
            btnPesqProdMarcaVoltar.TabIndex = 18;
            btnPesqProdMarcaVoltar.Text = "Voltar";
            btnPesqProdMarcaVoltar.UseVisualStyleBackColor = true;
            btnPesqProdMarcaVoltar.Click += btnPesqProdMarcaVoltar_Click;
            // 
            // btnPesqProdMarcaCancelar
            // 
            btnPesqProdMarcaCancelar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnPesqProdMarcaCancelar.Location = new Point(1308, 760);
            btnPesqProdMarcaCancelar.Name = "btnPesqProdMarcaCancelar";
            btnPesqProdMarcaCancelar.Size = new Size(128, 45);
            btnPesqProdMarcaCancelar.TabIndex = 17;
            btnPesqProdMarcaCancelar.Text = "Cancelar";
            btnPesqProdMarcaCancelar.UseVisualStyleBackColor = true;
            btnPesqProdMarcaCancelar.Click += btnPesqProdMarcaCancelar_Click;
            // 
            // btnPesqProdMarcaExcluir
            // 
            btnPesqProdMarcaExcluir.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnPesqProdMarcaExcluir.Location = new Point(372, 760);
            btnPesqProdMarcaExcluir.Name = "btnPesqProdMarcaExcluir";
            btnPesqProdMarcaExcluir.Size = new Size(128, 45);
            btnPesqProdMarcaExcluir.TabIndex = 16;
            btnPesqProdMarcaExcluir.Text = "Excluir";
            btnPesqProdMarcaExcluir.UseVisualStyleBackColor = true;
            btnPesqProdMarcaExcluir.Click += btnPesqProdMarcaExcluir_Click;
            // 
            // btnPesqProdMarcaAlterar
            // 
            btnPesqProdMarcaAlterar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnPesqProdMarcaAlterar.Location = new Point(193, 760);
            btnPesqProdMarcaAlterar.Name = "btnPesqProdMarcaAlterar";
            btnPesqProdMarcaAlterar.Size = new Size(128, 45);
            btnPesqProdMarcaAlterar.TabIndex = 15;
            btnPesqProdMarcaAlterar.Text = "Alterar";
            btnPesqProdMarcaAlterar.UseVisualStyleBackColor = true;
            btnPesqProdMarcaAlterar.Click += btnPesqProdMarcaAlterar_Click;
            // 
            // btnPesqProdMarcaNovo
            // 
            btnPesqProdMarcaNovo.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnPesqProdMarcaNovo.Location = new Point(59, 760);
            btnPesqProdMarcaNovo.Name = "btnPesqProdMarcaNovo";
            btnPesqProdMarcaNovo.Size = new Size(128, 45);
            btnPesqProdMarcaNovo.TabIndex = 14;
            btnPesqProdMarcaNovo.Text = "Novo";
            btnPesqProdMarcaNovo.UseVisualStyleBackColor = true;
            btnPesqProdMarcaNovo.Click += btnPesqProdMarcaNovo_Click;
            // 
            // dgMarca
            // 
            dgMarca.AllowUserToAddRows = false;
            dgMarca.AllowUserToDeleteRows = false;
            dgMarca.AllowUserToResizeColumns = false;
            dgMarca.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            dgMarca.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgMarca.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgMarca.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgMarca.DefaultCellStyle = dataGridViewCellStyle3;
            dgMarca.Location = new Point(59, 145);
            dgMarca.MultiSelect = false;
            dgMarca.Name = "dgMarca";
            dgMarca.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgMarca.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgMarca.RowHeadersWidth = 51;
            dgMarca.Size = new Size(1511, 609);
            dgMarca.TabIndex = 13;
            // 
            // btnPesqProdMarca
            // 
            btnPesqProdMarca.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnPesqProdMarca.Location = new Point(1424, 91);
            btnPesqProdMarca.Name = "btnPesqProdMarca";
            btnPesqProdMarca.Size = new Size(146, 38);
            btnPesqProdMarca.TabIndex = 12;
            btnPesqProdMarca.Text = "Pesquisar";
            btnPesqProdMarca.UseVisualStyleBackColor = true;
            btnPesqProdMarca.Click += btnPesqProdMarca_Click;
            // 
            // txtPesquisaProdMarca
            // 
            txtPesquisaProdMarca.CharacterCasing = CharacterCasing.Upper;
            txtPesquisaProdMarca.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            txtPesquisaProdMarca.Location = new Point(59, 92);
            txtPesquisaProdMarca.Name = "txtPesquisaProdMarca";
            txtPesquisaProdMarca.Size = new Size(1359, 38);
            txtPesquisaProdMarca.TabIndex = 11;
            // 
            // lblPesqProdMarca
            // 
            lblPesqProdMarca.AutoSize = true;
            lblPesqProdMarca.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblPesqProdMarca.Location = new Point(59, 55);
            lblPesqProdMarca.Name = "lblPesqProdMarca";
            lblPesqProdMarca.Size = new Size(366, 31);
            lblPesqProdMarca.TabIndex = 19;
            lblPesqProdMarca.Text = "Pesquisa de Produtos com Marca";
            // 
            // frmPesquisaMarca
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1622, 853);
            Controls.Add(lblPesqProdMarca);
            Controls.Add(btnPesqProdMarcaVoltar);
            Controls.Add(btnPesqProdMarcaCancelar);
            Controls.Add(btnPesqProdMarcaExcluir);
            Controls.Add(btnPesqProdMarcaAlterar);
            Controls.Add(btnPesqProdMarcaNovo);
            Controls.Add(dgMarca);
            Controls.Add(btnPesqProdMarca);
            Controls.Add(txtPesquisaProdMarca);
            Name = "frmPesquisaMarca";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmPesquisaMarca";
            ((System.ComponentModel.ISupportInitialize)dgMarca).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPesqProdMarcaVoltar;
        private Button btnPesqProdMarcaCancelar;
        private Button btnPesqProdMarcaExcluir;
        private Button btnPesqProdMarcaAlterar;
        private Button btnPesqProdMarcaNovo;
        private DataGridView dgMarca;
        private Button btnPesqProdMarca;
        private TextBox txtPesquisaProdMarca;
        private Label lblPesqProdMarca;
    }
}