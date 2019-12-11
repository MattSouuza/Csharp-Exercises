using System.Collections.Generic;
using RoleTopMVC.Models;

namespace RoleTopMVC.ViewModels
{
    public class DashboardViewModel : BaseViewModel
    {
        public List<Evento> Eventos {get;set;}
        public uint AgendamentoAprovados {get;set;}
        public uint AgendamentoReprovados {get;set;}
        public uint AgendamentoPendentes {get;set;}

        public DashboardViewModel()
        {
            this.Eventos = new List<Evento>();
        }
    }
}