using System;

namespace Foro2.Models
{
    public class FacturaViewModel
    {
        public int NumeroFactura { get; set; }
        public DateTime FechaFactura { get; set; }
        public decimal MontoTotal { get; set; }
    }
}
