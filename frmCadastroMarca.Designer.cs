namespace VendaEstorno

{
    partial class frmCadastroMarca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroMarca));
            lblMarcaCodigo = new Label();
            lblMarcaDescricao = new Label();
            txtMarcaCodigo = new TextBox();
            txtMarcaDescricao = new TextBox();
            btnMarcaGravar = new Button();
            btnMarcaCancelar = new Button();
            btnMarcaVoltar = new Button();
            SuspendLayout();
            // 
            // lblMarcaCodigo
            // 
            lblMarcaCodigo.AutoSize = true;
            lblMarcaCodigo.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblMarcaCodigo.Location = new Point(46, 38);
            lblMarcaCodigo.Name = "lblMarcaCodigo";
            lblMarcaCodigo.Size = new Size(91, 31);
            lblMarcaCodigo.TabIndex = 0;
            lblMarcaCodigo.Text = "Codigo";
            // 
            // lblMarcaDescricao
            // 
            lblMarcaDescricao.AutoSize = true;
            lblMarcaDescricao.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblMarcaDescricao.Location = new Point(46, 113);
            lblMarcaDescricao.Name = "lblMarcaDescricao";
            lblMarcaDescricao.Size = new Size(117, 31);
            lblMarcaDescricao.TabIndex = 1;
            lblMarcaDescricao.Text = "Descricao";
            // 
            // txtMarcaCodigo
            // 
            txtMarcaCodigo.Enabled = false;
            txtMarcaCodigo.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            txtMarcaCodigo.Location = new Point(46, 72);
            txtMarcaCodigo.Name = "txtMarcaCodigo";
            txtMarcaCodigo.ReadOnly = true;
            txtMarcaCodigo.Size = new Size(438, 38);
            txtMarcaCodigo.TabIndex = 2;
            // 
            // txtMarcaDescricao
            // 
            txtMarcaDescricao.CharacterCasing = CharacterCasing.Upper;
            txtMarcaDescricao.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            txtMarcaDescricao.Location = new Point(46, 147);
            txtMarcaDescricao.Name = "txtMarcaDescricao";
            txtMarcaDescricao.Size = new Size(438, 38);
            txtMarcaDescricao.TabIndex = 3;
            // 
            // btnMarcaGravar
            // 
            btnMarcaGravar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnMarcaGravar.Location = new Point(46, 191);
            btnMarcaGravar.Name = "btnMarcaGravar";
            btnMarcaGravar.Size = new Size(138, 50);
            btnMarcaGravar.TabIndex = 4;
            btnMarcaGravar.Text = "Guardar";
            btnMarcaGravar.UseVisualStyleBackColor = true;
            btnMarcaGravar.Click += btnMarcaGravar_Click;
            // 
            // btnMarcaCancelar
            // 
            btnMarcaCancelar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnMarcaCancelar.Location = new Point(190, 191);
            btnMarcaCancelar.Name = "btnMarcaCancelar";
            btnMarcaCancelar.Size = new Size(138, 50);
            btnMarcaCancelar.TabIndex = 5;
            btnMarcaCancelar.Text = "Cancelar";
            btnMarcaCancelar.UseVisualStyleBackColor = true;
            btnMarcaCancelar.Click += btnMarcaCancelar_Click;
            // 
            // btnMarcaVoltar
            // 
            btnMarcaVoltar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnMarcaVoltar.Location = new Point(346, 191);
            btnMarcaVoltar.Name = "btnMarcaVoltar";
            btnMarcaVoltar.Size = new Size(138, 50);
            btnMarcaVoltar.TabIndex = 6;
            btnMarcaVoltar.Text = "Voltar";
            btnMarcaVoltar.UseVisualStyleBackColor = true;
            btnMarcaVoltar.Click += btnMarcaVoltar_Click;
            // 
            // frmCadastroMarca
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(539, 291);
            Controls.Add(btnMarcaVoltar);
            Controls.Add(btnMarcaCancelar);
            Controls.Add(btnMarcaGravar);
            Controls.Add(txtMarcaDescricao);
            Controls.Add(txtMarcaCodigo);
            Controls.Add(lblMarcaDescricao);
            Controls.Add(lblMarcaCodigo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmCadastroMarca";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Marca";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMarcaCodigo;
        private Label lblMarcaDescricao;
        private TextBox txtMarcaCodigo;
        private TextBox txtMarcaDescricao;
        private Button btnMarcaGravar;
        private Button btnMarcaCancelar;
        private Button btnMarcaVoltar;
    }
}