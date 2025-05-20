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
            // Permite que o formulário capture as teclas antes dos controles
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
                    Hide(); // Esconde o formulário de login

                    using (var frmMenu = new frmMenu())
                    {
                        try
                        {
                            frmMenu.ShowDialog(); // Abre o formulário de menu como um diálogo modal
                        }
                        catch (Exception ex)
                        {
                            ShowMessage(ex.Message, "Aviso", MessageBoxIcon.Error);
                        }
                    }
                    Close(); // Fecha o formulário de login após o fechamento do menu
                }
                else
                {
                    ShowMessage("Usuário ou senha inválidos.", "Erro", MessageBoxIcon.Error);
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
                ShowMessage("Por favor, preencha todos os campos.", "Atenção", MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void HandleKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Impede o som de "beep" padrão do Enter
                btnLogin_Click(sender, EventArgs.Empty); // Simula o clique no botão de login
            }
        }

        private void ShowMessage(string message, string title, MessageBoxIcon icon)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, icon);
        }
    }
}