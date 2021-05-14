using System.Collections.Generic;

#nullable disable

namespace FBCalzado.Models
{
    public partial class Cliente
    {
        public Cliente()
        {
            Venta = new HashSet<Venta>();
        }

        public int IdCliente { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public int IdTipoIdent { get; set; }
        public string NumeroIdentificacion { get; set; }
        public string Email { get; set; }
        public long TelefonoFijo { get; set; }
        public long TelefonoCelular { get; set; }
        public string Direccion { get; set; }

        public virtual TipoIdentificacion IdTipoIdentNavigation { get; set; }
        public virtual ICollection<Venta> Venta { get; set; }
    }
}
