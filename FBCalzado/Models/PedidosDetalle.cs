#nullable disable

namespace FBCalzado.Models
{
    public partial class PedidosDetalle
    {
        public int IdPedDetalle { get; set; }
        public int IdPedido { get; set; }
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }
        public double ValorUnit { get; set; }
        public double ValorTotal { get; set; }

        public virtual Pedido IdPedidoNavigation { get; set; }
        public virtual Producto IdProductoNavigation { get; set; }
    }
}
