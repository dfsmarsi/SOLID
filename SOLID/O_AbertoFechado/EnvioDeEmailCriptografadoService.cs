namespace SOLID.O_AbertoFechado
{
    public class EnvioDeEmailCriptografadoService : EnvioDeEmailService
    {
        private ApiEmail ApiEmail { get; set; }

        public override void EnviarEmail(string assunto, string mensagem)
        {
            string mensagemCriptografada = CriptografarMensagemDoEmail(mensagem);
            ApiEmail.RealizarEnvioDeEmail(assunto, mensagemCriptografada);
        }

        private string CriptografarMensagemDoEmail(string mensagem)
        {
            return "";
        }
    }
}
