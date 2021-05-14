using System.Collections.Generic;

#nullable disable

namespace FBCalzado.Models
{
    public partial class Proveedore
    {
        public Proveedore()
        {
            Pedidos = new HashSet<Pedido>();
        }

        public int IdProveedor { get; set; }
        public string NombreProveedor { get; set; }
        public string Nit { get; set; }
        public long? TelefonoFijo { get; set; }
        public long TelefonoCelular { get; set; }
        public string EmailPrincipal { get; set; }
        public string? EmailSecundario { get; set; }
        public string? Direccion { get; set; }

        public virtual ICollection<Pedido> Pedidos { get; set; }
    }
}
