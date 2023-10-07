using Foro2.Models;
using System;
using System.Collections.Generic;

namespace Foro2.Models
{
    public class VentaViewModel
    {
        public int NumeroVenta { get; set; }
        public DateTime FechaVenta { get; set; }
        public List<ProductoViewModel> ProductosVendidos { get; set; }
    }
}
