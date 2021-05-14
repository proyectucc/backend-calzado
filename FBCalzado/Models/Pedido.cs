using System;
using System.Collections.Generic;

#nullable disable

namespace FBCalzado.Models
{
    public partial class Pedido
    {
        public Pedido()
        {
            PedidosDetalles = new HashSet<PedidosDetalle>();
        }

        public int IdPedido { get; set; }
        public int IdProveedor { get; set; }
        public DateTime? FechaPedido { get; set; }

        public virtual Proveedore IdProveedorNavigation { get; set; }
        public virtual ICollection<PedidosDetalle> PedidosDetalles { get; set; }
    }
}
