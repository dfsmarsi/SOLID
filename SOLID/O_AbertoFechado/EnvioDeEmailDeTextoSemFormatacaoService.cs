namespace SOLID.O_AbertoFechado
{
    public class EnvioDeEmailDeTextoSemFormatacaoService : EnvioDeEmailService
    {
        public ApiEmail ApiEmail { get; set; }

        public override void EnviarEmail(string assunto, string mensagem)
        {
            string mensagemSemFormatacao = RemoverFormatacaoDaMensagemDoEmail(mensagem);
            ApiEmail.RealizarEnvioDeEmail(assunto, mensagemSemFormatacao);
        }

        private string RemoverFormatacaoDaMensagemDoEmail(string mensagem)
        {
            return "";
        }
    }
}
