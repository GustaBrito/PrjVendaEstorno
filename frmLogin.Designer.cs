namespace VendaEstorno
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            btnLogin = new Button();
            txtUsuario = new TextBox();
            txtSenha = new TextBox();
            lblUsuario = new Label();
            lblSenha = new Label();
            lblTituloLogin = new Label();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.DeepSkyBlue;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(200, 245);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(264, 55);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Entrar";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.CharacterCasing = CharacterCasing.Upper;
            txtUsuario.Font = new Font("Segoe UI", 18F);
            txtUsuario.Location = new Point(200, 135);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(264, 47);
            txtUsuario.TabIndex = 1;
            // 
            // txtSenha
            // 
            txtSenha.Font = new Font("Segoe UI", 18F);
            txtSenha.Location = new Point(200, 192);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(264, 47);
            txtSenha.TabIndex = 2;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.BackColor = Color.Transparent;
            lblUsuario.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold);
            lblUsuario.ForeColor = Color.White;
            lblUsuario.Location = new Point(75, 145);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(119, 32);
            lblUsuario.TabIndex = 3;
            lblUsuario.Text = "Usuario";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.BackColor = Color.Transparent;
            lblSenha.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold);
            lblSenha.ForeColor = Color.White;
            lblSenha.Location = new Point(75, 202);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(102, 32);
            lblSenha.TabIndex = 4;
            lblSenha.Text = "Senha";
            // 
            // lblTituloLogin
            // 
            lblTituloLogin.AutoSize = true;
            lblTituloLogin.BackColor = Color.Transparent;
            lblTituloLogin.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloLogin.ForeColor = Color.White;
            lblTituloLogin.ImageAlign = ContentAlignment.TopCenter;
            lblTituloLogin.Location = new Point(75, 36);
            lblTituloLogin.Name = "lblTituloLogin";
            lblTituloLogin.Size = new Size(389, 46);
            lblTituloLogin.TabIndex = 5;
            lblTituloLogin.Text = "Controle de Acesso";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            BackgroundImage = Properties.Resources.Fundo;
            ClientSize = new Size(550, 352);
            Controls.Add(lblTituloLogin);
            Controls.Add(lblSenha);
            Controls.Add(lblUsuario);
            Controls.Add(txtSenha);
            Controls.Add(txtUsuario);
            Controls.Add(btnLogin);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private TextBox txtUsuario;
        private TextBox txtSenha;
        private Label lblUsuario;
        private Label lblSenha;
        private Label lblTituloLogin;
    }
}
