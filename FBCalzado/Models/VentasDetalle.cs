#nullable disable

namespace FBCalzado.Models
{
    public partial class VentasDetalle
    {
        public int IdVentDetalle { get; set; }
        public int IdVenta { get; set; }
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }
        public double ValorUnit { get; set; }
        public double ValorTotal { get; set; }

        public virtual Producto IdProductoNavigation { get; set; }
        public virtual Venta IdVentaNavigation { get; set; }
    }
}
