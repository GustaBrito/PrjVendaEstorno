namespace VendaEstorno

{
    partial class frmCadastroProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroProdutos));
            txtCadastroProd = new TextBox();
            txtQtdEstoque = new TextBox();
            txtPreco = new TextBox();
            txtDescricaoProd = new TextBox();
            txtTipoRegistro = new TextBox();
            cmbMarca = new ComboBox();
            lblCodigoProd = new Label();
            lblDescricao = new Label();
            lblQtdEstoque = new Label();
            lblPreco = new Label();
            lblDataVencimento = new Label();
            lblMarca = new Label();
            lblTipoRegistro = new Label();
            btnCadProdCadastrar = new Button();
            btnCadProdCancelar = new Button();
            btnCadProdVoltar = new Button();
            lblOrientacaoRegistro = new Label();
            mskDataVencto = new MaskedTextBox();
            SuspendLayout();
            // 
            // txtCadastroProd
            // 
            txtCadastroProd.CharacterCasing = CharacterCasing.Upper;
            txtCadastroProd.Enabled = false;
            txtCadastroProd.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold);
            txtCadastroProd.Location = new Point(42, 72);
            txtCadastroProd.Name = "txtCadastroProd";
            txtCadastroProd.ReadOnly = true;
            txtCadastroProd.Size = new Size(275, 34);
            txtCadastroProd.TabIndex = 0;
            // 
            // txtQtdEstoque
            // 
            txtQtdEstoque.CharacterCasing = CharacterCasing.Upper;
            txtQtdEstoque.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold);
            txtQtdEstoque.Location = new Point(42, 210);
            txtQtdEstoque.Name = "txtQtdEstoque";
            txtQtdEstoque.Size = new Size(302, 34);
            txtQtdEstoque.TabIndex = 1;
            txtQtdEstoque.KeyPress += txtQtdEstoque_KeyPress;
            // 
            // txtPreco
            // 
            txtPreco.CharacterCasing = CharacterCasing.Upper;
            txtPreco.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold);
            txtPreco.Location = new Point(354, 210);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(314, 34);
            txtPreco.TabIndex = 2;
            txtPreco.KeyPress += txtPreco_KeyPress;
            // 
            // txtDescricaoProd
            // 
            txtDescricaoProd.CharacterCasing = CharacterCasing.Upper;
            txtDescricaoProd.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold);
            txtDescricaoProd.Location = new Point(42, 141);
            txtDescricaoProd.Name = "txtDescricaoProd";
            txtDescricaoProd.Size = new Size(626, 34);
            txtDescricaoProd.TabIndex = 4;
            // 
            // txtTipoRegistro
            // 
            txtTipoRegistro.CharacterCasing = CharacterCasing.Upper;
            txtTipoRegistro.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold);
            txtTipoRegistro.Location = new Point(42, 348);
            txtTipoRegistro.MaxLength = 1;
            txtTipoRegistro.Name = "txtTipoRegistro";
            txtTipoRegistro.Size = new Size(168, 34);
            txtTipoRegistro.TabIndex = 5;
            txtTipoRegistro.KeyPress += txtTipoRegistro_KeyPress;
            // 
            // cmbMarca
            // 
            cmbMarca.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMarca.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold);
            cmbMarca.FormattingEnabled = true;
            cmbMarca.Location = new Point(354, 276);
            cmbMarca.Name = "cmbMarca";
            cmbMarca.Size = new Size(314, 37);
            cmbMarca.TabIndex = 6;
            cmbMarca.SelectedIndexChanged += cmbMarca_SelectedIndexChanged;
            // 
            // lblCodigoProd
            // 
            lblCodigoProd.AutoSize = true;
            lblCodigoProd.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold);
            lblCodigoProd.Location = new Point(42, 40);
            lblCodigoProd.Name = "lblCodigoProd";
            lblCodigoProd.Size = new Size(234, 29);
            lblCodigoProd.TabIndex = 7;
            lblCodigoProd.Text = "Codigo do Produto";
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold);
            lblDescricao.Location = new Point(42, 109);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(130, 29);
            lblDescricao.TabIndex = 8;
            lblDescricao.Text = "Descrição";
            // 
            // lblQtdEstoque
            // 
            lblQtdEstoque.AutoSize = true;
            lblQtdEstoque.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold);
            lblQtdEstoque.Location = new Point(42, 178);
            lblQtdEstoque.Name = "lblQtdEstoque";
            lblQtdEstoque.Size = new Size(288, 29);
            lblQtdEstoque.TabIndex = 9;
            lblQtdEstoque.Text = "Quantidade de Estoque";
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold);
            lblPreco.Location = new Point(354, 178);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(82, 29);
            lblPreco.TabIndex = 10;
            lblPreco.Text = "Preço";
            // 
            // lblDataVencimento
            // 
            lblDataVencimento.AutoSize = true;
            lblDataVencimento.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold);
            lblDataVencimento.Location = new Point(42, 247);
            lblDataVencimento.Name = "lblDataVencimento";
            lblDataVencimento.Size = new Size(150, 29);
            lblDataVencimento.TabIndex = 11;
            lblDataVencimento.Text = "Vencimento";
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold);
            lblMarca.Location = new Point(354, 247);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(84, 29);
            lblMarca.TabIndex = 12;
            lblMarca.Text = "Marca";
            // 
            // lblTipoRegistro
            // 
            lblTipoRegistro.AutoSize = true;
            lblTipoRegistro.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold);
            lblTipoRegistro.Location = new Point(42, 316);
            lblTipoRegistro.Name = "lblTipoRegistro";
            lblTipoRegistro.Size = new Size(210, 29);
            lblTipoRegistro.TabIndex = 13;
            lblTipoRegistro.Text = "Tipo do Registro";
            // 
            // btnCadProdCadastrar
            // 
            btnCadProdCadastrar.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold);
            btnCadProdCadastrar.Location = new Point(42, 388);
            btnCadProdCadastrar.Name = "btnCadProdCadastrar";
            btnCadProdCadastrar.Size = new Size(148, 52);
            btnCadProdCadastrar.TabIndex = 14;
            btnCadProdCadastrar.Text = "Guardar";
            btnCadProdCadastrar.UseVisualStyleBackColor = true;
            btnCadProdCadastrar.Click += btnCadProdCadastrar_Click;
            // 
            // btnCadProdCancelar
            // 
            btnCadProdCancelar.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold);
            btnCadProdCancelar.Location = new Point(196, 388);
            btnCadProdCancelar.Name = "btnCadProdCancelar";
            btnCadProdCancelar.Size = new Size(148, 52);
            btnCadProdCancelar.TabIndex = 15;
            btnCadProdCancelar.Text = "Cancelar";
            btnCadProdCancelar.UseVisualStyleBackColor = true;
            btnCadProdCancelar.Click += btnCadProdCancelar_Click;
            // 
            // btnCadProdVoltar
            // 
            btnCadProdVoltar.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold);
            btnCadProdVoltar.Location = new Point(520, 388);
            btnCadProdVoltar.Name = "btnCadProdVoltar";
            btnCadProdVoltar.Size = new Size(148, 52);
            btnCadProdVoltar.TabIndex = 16;
            btnCadProdVoltar.Text = "Voltar";
            btnCadProdVoltar.UseVisualStyleBackColor = true;
            btnCadProdVoltar.Click += btnCadProdVoltar_Click;
            // 
            // lblOrientacaoRegistro
            // 
            lblOrientacaoRegistro.AutoSize = true;
            lblOrientacaoRegistro.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOrientacaoRegistro.Location = new Point(219, 356);
            lblOrientacaoRegistro.Name = "lblOrientacaoRegistro";
            lblOrientacaoRegistro.Size = new Size(283, 22);
            lblOrientacaoRegistro.TabIndex = 18;
            lblOrientacaoRegistro.Text = "M - MANUAL / I - IMPORTADO";
            // 
            // mskDataVencto
            // 
            mskDataVencto.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mskDataVencto.Location = new Point(42, 274);
            mskDataVencto.Mask = "00/00/0000";
            mskDataVencto.Name = "mskDataVencto";
            mskDataVencto.Size = new Size(302, 38);
            mskDataVencto.TabIndex = 19;
            mskDataVencto.ValidatingType = typeof(DateTime);
            // 
            // frmCadastroProdutos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(725, 486);
            Controls.Add(mskDataVencto);
            Controls.Add(lblOrientacaoRegistro);
            Controls.Add(btnCadProdVoltar);
            Controls.Add(btnCadProdCancelar);
            Controls.Add(btnCadProdCadastrar);
            Controls.Add(lblTipoRegistro);
            Controls.Add(lblMarca);
            Controls.Add(lblDataVencimento);
            Controls.Add(lblPreco);
            Controls.Add(lblQtdEstoque);
            Controls.Add(lblDescricao);
            Controls.Add(lblCodigoProd);
            Controls.Add(cmbMarca);
            Controls.Add(txtTipoRegistro);
            Controls.Add(txtDescricaoProd);
            Controls.Add(txtPreco);
            Controls.Add(txtQtdEstoque);
            Controls.Add(txtCadastroProd);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmCadastroProdutos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCadastroProdutos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCadastroProd;
        private TextBox txtQtdEstoque;
        private TextBox txtPreco;
        private TextBox txtDescricaoProd;
        private TextBox txtTipoRegistro;
        private ComboBox cmbMarca;
        private Label lblCodigoProd;
        private Label lblDescricao;
        private Label lblQtdEstoque;
        private Label lblPreco;
        private Label lblDataVencimento;
        private Label lblMarca;
        private Label lblTipoRegistro;
        private Button btnCadProdCadastrar;
        private Button btnCadProdCancelar;
        private Button btnCadProdVoltar;
        private Label lblOrientacaoRegistro;
        private MaskedTextBox mskDataVencto;
    }
}