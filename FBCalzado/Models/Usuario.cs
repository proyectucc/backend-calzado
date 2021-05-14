using System;

#nullable disable

namespace FBCalzado.Models
{
    public partial class Usuario
    {
        public int IdUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaTerminacion { get; set; }
        public int? IdEmpleado { get; set; }

        public virtual Empleado IdEmpleadoNavigation { get; set; }
    }
}
