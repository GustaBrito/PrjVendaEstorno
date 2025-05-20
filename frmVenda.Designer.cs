namespace VendaEstorno
{
    partial class frmVenda
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
            lblProdutoVenda = new Label();
            lblQtdVenda = new Label();
            lblValorVenda = new Label();
            cmbProdutoVenda = new ComboBox();
            txtQtdVenda = new TextBox();
            txtValorVenda = new TextBox();
            btnAdicionar = new Button();
            btnGravarVenda = new Button();
            dgVenda = new DataGridView();
            btnExcluirVenda = new Button();
            btnVoltarVenda = new Button();
            btnCancelarVenda = new Button();
            lblEstoqueVenda = new Label();
            ((System.ComponentModel.ISupportInitialize)dgVenda).BeginInit();
            SuspendLayout();
            // 
            // lblProdutoVenda
            // 
            lblProdutoVenda.AutoSize = true;
            lblProdutoVenda.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblProdutoVenda.Location = new Point(58, 67);
            lblProdutoVenda.Name = "lblProdutoVenda";
            lblProdutoVenda.Size = new Size(102, 31);
            lblProdutoVenda.TabIndex = 0;
            lblProdutoVenda.Text = "Produto";
            // 
            // lblQtdVenda
            // 
            lblQtdVenda.AutoSize = true;
            lblQtdVenda.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblQtdVenda.Location = new Point(479, 67);
            lblQtdVenda.Name = "lblQtdVenda";
            lblQtdVenda.Size = new Size(243, 31);
            lblQtdVenda.TabIndex = 1;
            lblQtdVenda.Text = "Quantidade da Venda";
            // 
            // lblValorVenda
            // 
            lblValorVenda.AutoSize = true;
            lblValorVenda.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblValorVenda.Location = new Point(728, 67);
            lblValorVenda.Name = "lblValorVenda";
            lblValorVenda.Size = new Size(69, 31);
            lblValorVenda.TabIndex = 2;
            lblValorVenda.Text = "Valor";
            // 
            // cmbProdutoVenda
            // 
            cmbProdutoVenda.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProdutoVenda.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            cmbProdutoVenda.FormattingEnabled = true;
            cmbProdutoVenda.Location = new Point(58, 101);
            cmbProdutoVenda.Name = "cmbProdutoVenda";
            cmbProdutoVenda.Size = new Size(415, 39);
            cmbProdutoVenda.TabIndex = 3;
            cmbProdutoVenda.SelectedIndexChanged += cmbProdutoVenda_SelectedIndexChanged_1;
            // 
            // txtQtdVenda
            // 
            txtQtdVenda.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            txtQtdVenda.Location = new Point(479, 101);
            txtQtdVenda.Name = "txtQtdVenda";
            txtQtdVenda.Size = new Size(243, 38);
            txtQtdVenda.TabIndex = 4;
            // 
            // txtValorVenda
            // 
            txtValorVenda.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            txtValorVenda.Location = new Point(728, 101);
            txtValorVenda.Name = "txtValorVenda";
            txtValorVenda.ReadOnly = true;
            txtValorVenda.Size = new Size(133, 38);
            txtValorVenda.TabIndex = 5;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnAdicionar.Location = new Point(867, 101);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(149, 39);
            btnAdicionar.TabIndex = 6;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnGravarVenda
            // 
            btnGravarVenda.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnGravarVenda.Location = new Point(58, 780);
            btnGravarVenda.Name = "btnGravarVenda";
            btnGravarVenda.Size = new Size(127, 48);
            btnGravarVenda.TabIndex = 7;
            btnGravarVenda.Text = "Gravar";
            btnGravarVenda.UseVisualStyleBackColor = true;
            btnGravarVenda.Click += btnGravarVenda_Click;
            // 
            // dgVenda
            // 
            dgVenda.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            dgVenda.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgVenda.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgVenda.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgVenda.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgVenda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgVenda.DefaultCellStyle = dataGridViewCellStyle3;
            dgVenda.Location = new Point(58, 176);
            dgVenda.Name = "dgVenda";
            dgVenda.RowHeadersWidth = 51;
            dgVenda.Size = new Size(1509, 598);
            dgVenda.TabIndex = 8;
            // 
            // btnExcluirVenda
            // 
            btnExcluirVenda.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnExcluirVenda.Location = new Point(201, 780);
            btnExcluirVenda.Name = "btnExcluirVenda";
            btnExcluirVenda.Size = new Size(127, 48);
            btnExcluirVenda.TabIndex = 9;
            btnExcluirVenda.Text = "Excluir";
            btnExcluirVenda.UseVisualStyleBackColor = true;
            btnExcluirVenda.Click += btnExcluirVenda_Click;
            // 
            // btnVoltarVenda
            // 
            btnVoltarVenda.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnVoltarVenda.Location = new Point(1440, 780);
            btnVoltarVenda.Name = "btnVoltarVenda";
            btnVoltarVenda.Size = new Size(127, 48);
            btnVoltarVenda.TabIndex = 10;
            btnVoltarVenda.Text = "Voltar";
            btnVoltarVenda.UseVisualStyleBackColor = true;
            btnVoltarVenda.Click += btnVoltarVenda_Click;
            // 
            // btnCancelarVenda
            // 
            btnCancelarVenda.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnCancelarVenda.Location = new Point(1307, 780);
            btnCancelarVenda.Name = "btnCancelarVenda";
            btnCancelarVenda.Size = new Size(127, 48);
            btnCancelarVenda.TabIndex = 11;
            btnCancelarVenda.Text = "Cancelar";
            btnCancelarVenda.UseVisualStyleBackColor = true;
            btnCancelarVenda.Click += btnCancelarVenda_Click;
            // 
            // lblEstoqueVenda
            // 
            lblEstoqueVenda.AutoSize = true;
            lblEstoqueVenda.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblEstoqueVenda.Location = new Point(479, 142);
            lblEstoqueVenda.Name = "lblEstoqueVenda";
            lblEstoqueVenda.Size = new Size(105, 31);
            lblEstoqueVenda.TabIndex = 12;
            lblEstoqueVenda.Text = "Estoque:";
            // 
            // frmVenda
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1622, 853);
            Controls.Add(lblEstoqueVenda);
            Controls.Add(btnCancelarVenda);
            Controls.Add(btnVoltarVenda);
            Controls.Add(btnExcluirVenda);
            Controls.Add(dgVenda);
            Controls.Add(btnGravarVenda);
            Controls.Add(btnAdicionar);
            Controls.Add(txtValorVenda);
            Controls.Add(txtQtdVenda);
            Controls.Add(cmbProdutoVenda);
            Controls.Add(lblValorVenda);
            Controls.Add(lblQtdVenda);
            Controls.Add(lblProdutoVenda);
            Name = "frmVenda";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Venda";
            ((System.ComponentModel.ISupportInitialize)dgVenda).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProdutoVenda;
        private Label lblQtdVenda;
        private Label lblValorVenda;
        private ComboBox cmbProdutoVenda;
        private TextBox txtQtdVenda;
        private TextBox txtValorVenda;
        private Button btnAdicionar;
        private Button btnGravarVenda;
        private DataGridView dgVenda;
        private Button btnExcluirVenda;
        private Button btnVoltarVenda;
        private Button btnCancelarVenda;
        private Label lblEstoqueVenda;
    }
}