using VendaEstorno.code.Dal;

namespace VendaEstorno
{
    public partial class frmLogin : Form
    {
        private readonly ProdutosDal _usuariosDal = new ProdutosDal();

        public frmLogin()
        {
            InitializeComponent();
            // Associa o evento KeyDown para os TextBoxes
            txtUsuario.KeyDown += HandleKeyDown;
            txtSenha.KeyDown += HandleKeyDown;
            // Permite que o formul�rio capture as teclas antes dos controles
            this.KeyPreview = true;
            this.KeyDown += HandleKeyDown;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string senha = txtSenha.Text.Trim();

            if (!ValidateInputs(usuario, senha))
                return;

            try
            {
                if (_usuariosDal.ValidarCredenciais(usuario, senha))
                {
                    ShowMessage("Login bem-sucedido!", "Sucesso", MessageBoxIcon.Information);
                    Hide(); // Esconde o formul�rio de login

                    using (var frmMenu = new frmMenu())
                    {
                        try
                        {
                            frmMenu.ShowDialog(); // Abre o formul�rio de menu como um di�logo modal
                        }
                        catch (Exception ex)
                        {
                            ShowMessage(ex.Message, "Aviso", MessageBoxIcon.Error);
                        }
                    }
                    Close(); // Fecha o formul�rio de login ap�s o fechamento do menu
                }
                else
                {
                    ShowMessage("Usu�rio ou senha inv�lidos.", "Erro", MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                ShowMessage(ex.Message, "Erro", MessageBoxIcon.Error);
            }
        }

        private bool ValidateInputs(string usuario, string senha)
        {
            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(senha))
            {
                ShowMessage("Por favor, preencha todos os campos.", "Aten��o", MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void HandleKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Impede o som de "beep" padr�o do Enter
                btnLogin_Click(sender, EventArgs.Empty); // Simula o clique no bot�o de login
            }
        }

        private void ShowMessage(string message, string title, MessageBoxIcon icon)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, icon);
        }
    }
}