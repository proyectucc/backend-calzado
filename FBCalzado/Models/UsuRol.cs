#nullable disable

namespace FBCalzado.Models
{
    public partial class UsuRol
    {
        public int IdUsuario { get; set; }
        public int IdRol { get; set; }

        public virtual Role IdRolNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
