using RoleTopMVC.Models;

namespace RoleTopMVC.ViewModels
{
    public class AgendamentoViewModel : BaseViewModel
    {
        public Cliente Cliente {get;set;}
        public Evento Evento {get;set;}
    }
}