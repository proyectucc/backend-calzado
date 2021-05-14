using System.Collections.Generic;

#nullable disable

namespace FBCalzado.Models
{
    public partial class Producto
    {
        public Producto()
        {
            PedidosDetalles = new HashSet<PedidosDetalle>();
            VentasDetalles = new HashSet<VentasDetalle>();
        }

        public int IdProducto { get; set; }
        public int IdCategoria { get; set; }
        public int IdMarca { get; set; }
        public string NombreProducto { get; set; }
        public double CostoCompra { get; set; }
        public double CostoVenta { get; set; }
        public int Cantidad { get; set; }
        public string Descripcion { get; set; }

        public virtual Categoria IdCategoriaNavigation { get; set; }
        public virtual Marca IdMarcaNavigation { get; set; }
        public virtual ICollection<PedidosDetalle> PedidosDetalles { get; set; }
        public virtual ICollection<VentasDetalle> VentasDetalles { get; set; }
    }
}
