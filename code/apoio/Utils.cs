using System.Configuration;
using System.Reflection;
using System.Windows.Forms;

namespace EtiquetaValidade.code.apoio
{
    public static class Utils
    {
        public static readonly string Impressora;

        public const string NOME_SISTEMA = "Etiqueta de Validade";
        public static string VERSAO_SISTEMA = Assembly.GetExecutingAssembly().GetName().Version.ToString();

        static Utils()
        {
            Impressora = ConfigurationManager.AppSettings["Impressora"];
        }

        public static void MsgAguarde(Label nomeLabel, string mensagem, bool exibir)
        {
            nomeLabel.Text = mensagem;
            nomeLabel.Visible = exibir;
            nomeLabel.Refresh();
        }

        public static void MsgErro(string pMensagem)
        {
            MessageBox.Show(pMensagem, NOME_SISTEMA, MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        public static void MsgExclamation(string pMensagem)
        {
            MessageBox.Show(pMensagem, NOME_SISTEMA, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public static void MsgInformation(string pMensagem)
        {
            MessageBox.Show(pMensagem, NOME_SISTEMA, MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        public static DialogResult MsgPergunta(string mensagem)
        {
            return MessageBox.Show(mensagem, NOME_SISTEMA, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

    }
}
