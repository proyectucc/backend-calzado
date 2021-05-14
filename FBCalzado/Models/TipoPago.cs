using System.Collections.Generic;

#nullable disable

namespace FBCalzado.Models
{
    public partial class TipoPago
    {
        public TipoPago()
        {
            Venta = new HashSet<Venta>();
        }

        public int IdTipoPago { get; set; }
        public string TipoPago1 { get; set; }

        public virtual ICollection<Venta> Venta { get; set; }
    }
}
