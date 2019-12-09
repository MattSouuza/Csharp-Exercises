using System.Collections.Generic;
using RoleTopMVC.Models;

namespace RoleTopMVC.ViewModels
{
    public class AgendamentoViewModel : BaseViewModel
    {
        public Cliente Cliente {get;set;}
        public Evento Evento {get;set;}
        public List<Planos> Planos {get;set;}

        public AgendamentoViewModel()
        {
            this.Planos = new List<Planos>();
            this.Cliente = new Cliente();
            this.Evento = new Evento();
        }
    }
}