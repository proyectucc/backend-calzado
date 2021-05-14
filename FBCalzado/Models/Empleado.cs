using System;

#nullable disable

namespace FBCalzado.Models
{
    public partial class Empleado
    {
        //public Empleado()
        //{
        //    Usuarios = new HashSet<Usuario>();
        //    Venta = new HashSet<Venta>();
        //}

        public int IdEmpleado { get; set; }
        public string PrimerNombre { get; set; }
        public string? SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string? SegundoApellido { get; set; }
        public int IdTipoIdent { get; set; }
        public string NumeroIdentificacion { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public DateTime FechaContratacion { get; set; }
        public DateTime? FechaTerminacion { get; set; }
        public string EmailPrincipal { get; set; }
        public long? TelefonoFijo { get; set; }
        public long TelefonoCelular { get; set; }
        public string Rol { get; set; }

        //public virtual TipoIdentificacion IdTipoIdentNavigation { get; set; }
        //public virtual ICollection<Usuario> Usuarios { get; set; }
        //public virtual ICollection<Venta> Venta { get; set; }
    }
}
