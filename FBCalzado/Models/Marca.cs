using System.Collections.Generic;

#nullable disable

namespace FBCalzado.Models
{
    public partial class Marca
    {
        public Marca()
        {
            Productos = new HashSet<Producto>();
        }

        public int IdMarca { get; set; }
        public string NombreMarca { get; set; }

        public virtual ICollection<Producto> Productos { get; set; }
    }
}
