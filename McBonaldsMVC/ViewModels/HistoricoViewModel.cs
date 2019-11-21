using System.Collections.Generic;
using McBonaldsMVC.Models;

namespace McBonaldsMVC.ViewModels
{
    public class HistoricoViewModel
    {
        public List<Pedido> Pedido {get;set;}
        public List<Pedido> Pedidos { get; internal set; }
    }
}