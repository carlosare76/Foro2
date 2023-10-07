using Foro2.Models;
using System;
using System.Collections.Generic;

namespace Foro2.Models
{
    public class PedidoViewModel
    {
        public int NumeroPedido { get; set; }
        public DateTime FechaPedido { get; set; }
        public List<ProductoViewModel> Productos { get; set; }
    }
}