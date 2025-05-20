namespace VendaEstorno
{
    partial class frmPesquisaProdutos
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
            cmbPesqProd = new ComboBox();
            txtPesqProd = new TextBox();
            btnPesquisaProd = new Button();
            dgProduto = new DataGridView();
            CODPRODUTO = new DataGridViewTextBoxColumn();
            DESCRICAO = new DataGridViewTextBoxColumn();
            PRECO = new DataGridViewTextBoxColumn();
            QTDESTOQUE = new DataGridViewTextBoxColumn();
            DATAVENCTO = new DataGridViewTextBoxColumn();
            TIPOREGISTRO = new DataGridViewTextBoxColumn();
            btnPesquisaProdNovo = new Button();
            btnPesquisaProdAlterar = new Button();
            btnPesquisaProdExcluir = new Button();
            btnPesquisaProdCancelar = new Button();
            btnPesquisaProdVoltar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgProduto).BeginInit();
            SuspendLayout();
            // 
            // cmbPesqProd
            // 
            cmbPesqProd.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPesqProd.Font = new Font("Segoe UI", 13.8F);
            cmbPesqProd.FormattingEnabled = true;
            cmbPesqProd.Items.AddRange(new object[] { "CODIGO", "ESTOQUE", "PRECO", "VENCIMENTO", "CODIGO DE MARCA", "REGISTRO", "DESCRICAO" });
            cmbPesqProd.Location = new Point(37, 80);
            cmbPesqProd.Name = "cmbPesqProd";
            cmbPesqProd.Size = new Size(411, 39);
            cmbPesqProd.TabIndex = 0;
            cmbPesqProd.SelectedIndexChanged += cmbPesqProd_SelectedIndexChanged;
            // 
            // txtPesqProd
            // 
            txtPesqProd.CharacterCasing = CharacterCasing.Upper;
            txtPesqProd.Font = new Font("Segoe UI", 13.8F);
            txtPesqProd.Location = new Point(454, 80);
            txtPesqProd.Name = "txtPesqProd";
            txtPesqProd.Size = new Size(787, 38);
            txtPesqProd.TabIndex = 1;
            // 
            // btnPesquisaProd
            // 
            btnPesquisaProd.Font = new Font("Segoe UI", 13.8F);
            btnPesquisaProd.Location = new Point(1247, 76);
            btnPesquisaProd.Name = "btnPesquisaProd";
            btnPesquisaProd.Size = new Size(185, 44);
            btnPesquisaProd.TabIndex = 2;
            btnPesquisaProd.Text = "Pesquisar";
            btnPesquisaProd.UseVisualStyleBackColor = true;
            btnPesquisaProd.Click += btnPesquisaProd_Click;
            // 
            // dgProduto
            // 
            dgProduto.AllowUserToAddRows = false;
            dgProduto.AllowUserToDeleteRows = false;
            dgProduto.AllowUserToResizeColumns = false;
            dgProduto.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            dgProduto.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgProduto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgProduto.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgProduto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgProduto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgProduto.Columns.AddRange(new DataGridViewColumn[] { CODPRODUTO, DESCRICAO, PRECO, QTDESTOQUE, DATAVENCTO, TIPOREGISTRO });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgProduto.DefaultCellStyle = dataGridViewCellStyle3;
            dgProduto.Location = new Point(37, 126);
            dgProduto.MultiSelect = false;
            dgProduto.Name = "dgProduto";
            dgProduto.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgProduto.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgProduto.RowHeadersWidth = 51;
            dgProduto.Size = new Size(1555, 663);
            dgProduto.TabIndex = 3;
            dgProduto.CellContentClick += dgProduto_CellContentClick;
            dgProduto.SelectionChanged += dgProduto_SelectionChanged;
            // 
            // CODPRODUTO
            // 
            CODPRODUTO.DataPropertyName = "CODPRODUTO";
            CODPRODUTO.HeaderText = "CODIGO";
            CODPRODUTO.MinimumWidth = 6;
            CODPRODUTO.Name = "CODPRODUTO";
            CODPRODUTO.ReadOnly = true;
            // 
            // DESCRICAO
            // 
            DESCRICAO.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DESCRICAO.DataPropertyName = "DESCRICAO";
            DESCRICAO.HeaderText = "DESCRICAO";
            DESCRICAO.MinimumWidth = 6;
            DESCRICAO.Name = "DESCRICAO";
            DESCRICAO.ReadOnly = true;
            // 
            // PRECO
            // 
            PRECO.DataPropertyName = "PRECO";
            PRECO.HeaderText = "PRECO";
            PRECO.MinimumWidth = 6;
            PRECO.Name = "PRECO";
            PRECO.ReadOnly = true;
            // 
            // QTDESTOQUE
            // 
            QTDESTOQUE.DataPropertyName = "QTDESTOQUE";
            QTDESTOQUE.HeaderText = "ESTOQUE";
            QTDESTOQUE.MinimumWidth = 6;
            QTDESTOQUE.Name = "QTDESTOQUE";
            QTDESTOQUE.ReadOnly = true;
            // 
            // DATAVENCTO
            // 
            DATAVENCTO.DataPropertyName = "DATAVENCTO";
            DATAVENCTO.HeaderText = "VENCIMENTO";
            DATAVENCTO.MinimumWidth = 6;
            DATAVENCTO.Name = "DATAVENCTO";
            DATAVENCTO.ReadOnly = true;
            // 
            // TIPOREGISTRO
            // 
            TIPOREGISTRO.DataPropertyName = "TIPOREGISTRO";
            TIPOREGISTRO.HeaderText = "REGISTRO";
            TIPOREGISTRO.MinimumWidth = 6;
            TIPOREGISTRO.Name = "TIPOREGISTRO";
            TIPOREGISTRO.ReadOnly = true;
            // 
            // btnPesquisaProdNovo
            // 
            btnPesquisaProdNovo.Font = new Font("Segoe UI", 13.8F);
            btnPesquisaProdNovo.Location = new Point(37, 795);
            btnPesquisaProdNovo.Name = "btnPesquisaProdNovo";
            btnPesquisaProdNovo.Size = new Size(185, 44);
            btnPesquisaProdNovo.TabIndex = 4;
            btnPesquisaProdNovo.Text = "Novo";
            btnPesquisaProdNovo.UseVisualStyleBackColor = true;
            btnPesquisaProdNovo.Click += btnPesquisaProdNovo_Click;
            // 
            // btnPesquisaProdAlterar
            // 
            btnPesquisaProdAlterar.Font = new Font("Segoe UI", 13.8F);
            btnPesquisaProdAlterar.Location = new Point(228, 795);
            btnPesquisaProdAlterar.Name = "btnPesquisaProdAlterar";
            btnPesquisaProdAlterar.Size = new Size(185, 44);
            btnPesquisaProdAlterar.TabIndex = 5;
            btnPesquisaProdAlterar.Text = "Alterar";
            btnPesquisaProdAlterar.UseVisualStyleBackColor = true;
            btnPesquisaProdAlterar.Click += btnPesquisaProdAlterar_Click;
            // 
            // btnPesquisaProdExcluir
            // 
            btnPesquisaProdExcluir.Font = new Font("Segoe UI", 13.8F);
            btnPesquisaProdExcluir.Location = new Point(467, 795);
            btnPesquisaProdExcluir.Name = "btnPesquisaProdExcluir";
            btnPesquisaProdExcluir.Size = new Size(185, 44);
            btnPesquisaProdExcluir.TabIndex = 6;
            btnPesquisaProdExcluir.Text = "Excluir";
            btnPesquisaProdExcluir.UseVisualStyleBackColor = true;
            btnPesquisaProdExcluir.Click += btnPesquisaProdExcluir_Click;
            // 
            // btnPesquisaProdCancelar
            // 
            btnPesquisaProdCancelar.Font = new Font("Segoe UI", 13.8F);
            btnPesquisaProdCancelar.Location = new Point(1216, 795);
            btnPesquisaProdCancelar.Name = "btnPesquisaProdCancelar";
            btnPesquisaProdCancelar.Size = new Size(185, 44);
            btnPesquisaProdCancelar.TabIndex = 8;
            btnPesquisaProdCancelar.Text = "Cancelar";
            btnPesquisaProdCancelar.UseVisualStyleBackColor = true;
            btnPesquisaProdCancelar.Click += btnPesquisaProdCancelar_Click;
            // 
            // btnPesquisaProdVoltar
            // 
            btnPesquisaProdVoltar.Font = new Font("Segoe UI", 13.8F);
            btnPesquisaProdVoltar.Location = new Point(1407, 795);
            btnPesquisaProdVoltar.Name = "btnPesquisaProdVoltar";
            btnPesquisaProdVoltar.Size = new Size(185, 44);
            btnPesquisaProdVoltar.TabIndex = 9;
            btnPesquisaProdVoltar.Text = "Voltar";
            btnPesquisaProdVoltar.UseVisualStyleBackColor = true;
            btnPesquisaProdVoltar.Click += btnPesquisaProdVoltar_Click;
            // 
            // frmPesquisaProdutos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1622, 853);
            Controls.Add(btnPesquisaProdVoltar);
            Controls.Add(btnPesquisaProdCancelar);
            Controls.Add(btnPesquisaProdExcluir);
            Controls.Add(btnPesquisaProdAlterar);
            Controls.Add(btnPesquisaProdNovo);
            Controls.Add(dgProduto);
            Controls.Add(btnPesquisaProd);
            Controls.Add(txtPesqProd);
            Controls.Add(cmbPesqProd);
            Name = "frmPesquisaProdutos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PesquisaProdutos";
            Load += frmPesquisaProdutos_Load;
            ((System.ComponentModel.ISupportInitialize)dgProduto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbPesqProd;
        private TextBox txtPesqProd;
        private Button btnPesquisaProd;
        private DataGridView dgProduto;
        private Button btnPesquisaProdNovo;
        private Button btnPesquisaProdAlterar;
        private Button btnPesquisaProdExcluir;
        private Button button5;
        private Button btnPesquisaProdCancelar;
        private Button btnPesquisaProdVoltar;
        private DataGridViewTextBoxColumn CODPRODUTO;
        private DataGridViewTextBoxColumn DESCRICAO;
        private DataGridViewTextBoxColumn PRECO;
        private DataGridViewTextBoxColumn QTDESTOQUE;
        private DataGridViewTextBoxColumn DATAVENCTO;
        private DataGridViewTextBoxColumn TIPOREGISTRO;
    }
}