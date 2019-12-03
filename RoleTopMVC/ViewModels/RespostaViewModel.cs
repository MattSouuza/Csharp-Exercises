namespace RoleTopMVC.ViewModels
{
    public class RespostaViewModel : BaseViewModel
    {
        public string Mensagem {get;set;}

        public RespostaViewModel(string mensagem)
        {
            this.Mensagem = mensagem;
        }
    }
}