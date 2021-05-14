using System;
using System.Collections.Generic;

#nullable disable

namespace FBCalzado.Models
{
    public partial class Venta
    {
        public Venta()
        {
            VentasDetalles = new HashSet<VentasDetalle>();
        }

        public int IdVenta { get; set; }
        public int IdCliente { get; set; }
        public int IdEmpleado { get; set; }
        public DateTime FechaVenta { get; set; }
        public int IdTipoPago { get; set; }

        public virtual Cliente IdClienteNavigation { get; set; }
        public virtual Empleado IdEmpleadoNavigation { get; set; }
        public virtual TipoPago IdTipoPagoNavigation { get; set; }
        public virtual ICollection<VentasDetalle> VentasDetalles { get; set; }
    }
}
