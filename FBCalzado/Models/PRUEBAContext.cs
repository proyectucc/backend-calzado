using Microsoft.EntityFrameworkCore;

#nullable disable

namespace FBCalzado.Models
{
    public partial class PRUEBAContext : DbContext
    {
        public PRUEBAContext()
        {
        }

        public PRUEBAContext(DbContextOptions<PRUEBAContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Categoria> Categorias { get; set; }
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Empleado> Empleados { get; set; }
        public virtual DbSet<Marca> Marcas { get; set; }
        public virtual DbSet<Pedido> Pedidos { get; set; }
        public virtual DbSet<PedidosDetalle> PedidosDetalles { get; set; }
        public virtual DbSet<Producto> Productos { get; set; }
        public virtual DbSet<Proveedore> Proveedores { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<TipoIdentificacion> TipoIdentificacions { get; set; }
        public virtual DbSet<TipoPago> TipoPagos { get; set; }
        public virtual DbSet<UsuRol> UsuRols { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<Venta> Ventas { get; set; }
        public virtual DbSet<VentasDetalle> VentasDetalles { get; set; }

        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=localhost;Database=PRUEBA;Trusted_Connection=True;");
            }
        }*/

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Categoria>(entity =>
            {
                entity.HasKey(e => e.IdCategoria)
                    .HasName("PK__CATEGORI__4BD51FA53F029E7A");

                entity.ToTable("CATEGORIAS");

                entity.Property(e => e.IdCategoria).HasColumnName("ID_CATEGORIA");

                entity.Property(e => e.NombreCategoria)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE_CATEGORIA");
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.IdCliente)
                    .HasName("PK__CLIENTES__23A3413064288B0B");

                entity.ToTable("CLIENTES");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("DIRECCION");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.IdTipoIdent).HasColumnName("ID_TIPO_IDENT");

                entity.Property(e => e.NumeroIdentificacion)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("NUMERO_IDENTIFICACION");

                entity.Property(e => e.PrimerApellido)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PRIMER_APELLIDO");

                entity.Property(e => e.PrimerNombre)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PRIMER_NOMBRE");

                entity.Property(e => e.SegundoApellido)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SEGUNDO_APELLIDO");

                entity.Property(e => e.SegundoNombre)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SEGUNDO_NOMBRE");

                entity.Property(e => e.TelefonoCelular).HasColumnName("TELEFONO_CELULAR");

                entity.Property(e => e.TelefonoFijo).HasColumnName("TELEFONO_FIJO");

            });

            modelBuilder.Entity<Empleado>(entity =>
            {
                entity.HasKey(e => e.IdEmpleado)
                    .HasName("PK__EMPLEADO__922CA26964234ED3");

                entity.ToTable("EMPLEADOS");

                entity.Property(e => e.IdEmpleado).HasColumnName("ID_EMPLEADO");

                entity.Property(e => e.EmailPrincipal)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL_PRINCIPAL");

                entity.Property(e => e.FechaContratacion)
                    .HasColumnType("date")
                    .HasColumnName("FECHA_CONTRATACION");

                entity.Property(e => e.FechaNacimiento)
                    .HasColumnType("date")
                    .HasColumnName("FECHA_NACIMIENTO");

                entity.Property(e => e.FechaTerminacion)
                    .HasColumnType("date")
                    .HasColumnName("FECHA_TERMINACION");

                entity.Property(e => e.IdTipoIdent).HasColumnName("ID_TIPO_IDENT");

                entity.Property(e => e.NumeroIdentificacion)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("NUMERO_IDENTIFICACION");

                entity.Property(e => e.PrimerApellido)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PRIMER_APELLIDO");

                entity.Property(e => e.PrimerNombre)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PRIMER_NOMBRE");

                entity.Property(e => e.SegundoApellido)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SEGUNDO_APELLIDO");

                entity.Property(e => e.SegundoNombre)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SEGUNDO_NOMBRE");

                entity.Property(e => e.Rol)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ROL");

                entity.Property(e => e.TelefonoCelular).HasColumnName("TELEFONO_CELULAR");

                entity.Property(e => e.TelefonoFijo).HasColumnName("TELEFONO_FIJO");

            });

            modelBuilder.Entity<Marca>(entity =>
            {
                entity.HasKey(e => e.IdMarca)
                    .HasName("PK__MARCAS__A9FDC4BB7AC5147F");

                entity.ToTable("MARCAS");

                entity.Property(e => e.IdMarca).HasColumnName("ID_MARCA");

                entity.Property(e => e.NombreMarca)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE_MARCA");
            });

            modelBuilder.Entity<Pedido>(entity =>
            {
                entity.HasKey(e => e.IdPedido)
                    .HasName("PK__PEDIDOS__A05C2F2A54561818");

                entity.ToTable("PEDIDOS");

                entity.Property(e => e.IdPedido).HasColumnName("ID_PEDIDO");

                entity.Property(e => e.FechaPedido)
                    .HasColumnType("date")
                    .HasColumnName("FECHA_PEDIDO");

                entity.Property(e => e.IdProveedor).HasColumnName("ID_PROVEEDOR");

                entity.HasOne(d => d.IdProveedorNavigation)
                    .WithMany(p => p.Pedidos)
                    .HasForeignKey(d => d.IdProveedor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PEDIDOS__ID_PROV__47DBAE45");
            });

            modelBuilder.Entity<PedidosDetalle>(entity =>
            {
                entity.HasKey(e => e.IdPedDetalle)
                    .HasName("PK__PEDIDOS___8BF61511BB4A86F1");

                entity.ToTable("PEDIDOS_DETALLE");

                entity.Property(e => e.IdPedDetalle).HasColumnName("ID_PED_DETALLE");

                entity.Property(e => e.Cantidad).HasColumnName("CANTIDAD");

                entity.Property(e => e.IdPedido).HasColumnName("ID_PEDIDO");

                entity.Property(e => e.IdProducto).HasColumnName("ID_PRODUCTO");

                entity.Property(e => e.ValorTotal).HasColumnName("VALOR_TOTAL");

                entity.Property(e => e.ValorUnit).HasColumnName("VALOR_UNIT");

                entity.HasOne(d => d.IdPedidoNavigation)
                    .WithMany(p => p.PedidosDetalles)
                    .HasForeignKey(d => d.IdPedido)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PEDIDOS_D__ID_PE__4AB81AF0");

                entity.HasOne(d => d.IdProductoNavigation)
                    .WithMany(p => p.PedidosDetalles)
                    .HasForeignKey(d => d.IdProducto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PEDIDOS_D__ID_PR__4BAC3F29");
            });

            modelBuilder.Entity<Producto>(entity =>
            {
                entity.HasKey(e => e.IdProducto)
                    .HasName("PK__PRODUCTO__88BD03576BED09EA");

                entity.ToTable("PRODUCTOS");

                entity.Property(e => e.IdProducto).HasColumnName("ID_PRODUCTO");

                entity.Property(e => e.Cantidad).HasColumnName("CANTIDAD");

                entity.Property(e => e.CostoCompra).HasColumnName("COSTO_COMPRA");

                entity.Property(e => e.CostoVenta).HasColumnName("COSTO_VENTA");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPCION");

                entity.Property(e => e.IdCategoria).HasColumnName("ID_CATEGORIA");

                entity.Property(e => e.IdMarca).HasColumnName("ID_MARCA");

                entity.Property(e => e.NombreProducto)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE_PRODUCTO");

                entity.HasOne(d => d.IdCategoriaNavigation)
                    .WithMany(p => p.Productos)
                    .HasForeignKey(d => d.IdCategoria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PRODUCTOS__ID_CA__35BCFE0A");

                entity.HasOne(d => d.IdMarcaNavigation)
                    .WithMany(p => p.Productos)
                    .HasForeignKey(d => d.IdMarca)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PRODUCTOS__ID_MA__36B12243");
            });

            modelBuilder.Entity<Proveedore>(entity =>
            {
                entity.HasKey(e => e.IdProveedor)
                    .HasName("PK__PROVEEDO__733DB4C458C14F9D");

                entity.ToTable("PROVEEDORES");

                entity.Property(e => e.IdProveedor).HasColumnName("ID_PROVEEDOR");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("DIRECCION");

                entity.Property(e => e.EmailPrincipal)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL_PRINCIPAL");

                entity.Property(e => e.EmailSecundario)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL_SECUNDARIO");

                entity.Property(e => e.Nit)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("NIT");

                entity.Property(e => e.NombreProveedor)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE_PROVEEDOR");

                entity.Property(e => e.TelefonoFijo).HasColumnName("TELEFONO_FIJO");
                entity.Property(e => e.TelefonoCelular).HasColumnName("TELEFONO_CELULAR");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.HasKey(e => e.IdRol)
                    .HasName("PK__ROLES__203B0F6813F281B7");

                entity.ToTable("ROLES");

                entity.Property(e => e.IdRol).HasColumnName("ID_ROL");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPCION");

                entity.Property(e => e.NombreRol)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE_ROL");
            });

            modelBuilder.Entity<TipoIdentificacion>(entity =>
            {
                entity.HasKey(e => e.IdTipoIdent)
                    .HasName("PK__TIPO_IDE__1D4F1675E30F42D2");

                entity.ToTable("TIPO_IDENTIFICACION");

                entity.Property(e => e.IdTipoIdent).HasColumnName("ID_TIPO_IDENT");

                entity.Property(e => e.Mask).HasColumnName("MASK");

                entity.Property(e => e.TipoIdent)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("TIPO_IDENT");
            });

            modelBuilder.Entity<TipoPago>(entity =>
            {
                entity.HasKey(e => e.IdTipoPago)
                    .HasName("PK__TIPO_PAG__5A5E9B59DF322AD9");

                entity.ToTable("TIPO_PAGO");

                entity.Property(e => e.IdTipoPago).HasColumnName("ID_TIPO_PAGO");

                entity.Property(e => e.TipoPago1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TIPO_PAGO");
            });

            modelBuilder.Entity<UsuRol>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("USU_ROL");

                entity.Property(e => e.IdRol).HasColumnName("ID_ROL");

                entity.Property(e => e.IdUsuario).HasColumnName("ID_USUARIO");

                entity.HasOne(d => d.IdRolNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdRol)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__USU_ROL__ID_ROL__3C69FB99");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__USU_ROL__ID_USUA__3B75D760");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario)
                    .HasName("PK__USUARIOS__91136B90CF99BDA6");

                entity.ToTable("USUARIOS");

                entity.Property(e => e.IdUsuario).HasColumnName("ID_USUARIO");

                entity.Property(e => e.Contraseña)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CONTRASEÑA");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("date")
                    .HasColumnName("FECHA_CREACION");

                entity.Property(e => e.FechaTerminacion)
                    .HasColumnType("date")
                    .HasColumnName("FECHA_TERMINACION");

                entity.Property(e => e.IdEmpleado).HasColumnName("ID_EMPLEADO");

                entity.Property(e => e.NombreUsuario)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE_USUARIO");

                //entity.HasOne(d => d.IdEmpleadoNavigation)
                //    .WithMany(p => p.Usuarios)
                //    .HasForeignKey(d => d.IdEmpleado)
                //    .HasConstraintName("FK__USUARIOS__ID_EMP__398D8EEE");
            });

            modelBuilder.Entity<Venta>(entity =>
            {
                entity.HasKey(e => e.IdVenta)
                    .HasName("PK__VENTAS__F3B6C1B4F8216D87");

                entity.ToTable("VENTAS");

                entity.Property(e => e.IdVenta).HasColumnName("ID_VENTA");

                entity.Property(e => e.FechaVenta)
                    .HasColumnType("date")
                    .HasColumnName("FECHA_VENTA");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdEmpleado).HasColumnName("ID_EMPLEADO");

                entity.Property(e => e.IdTipoPago).HasColumnName("ID_TIPO_PAGO");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.Venta)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VENTAS__ID_CLIEN__3F466844");

                //entity.HasOne(d => d.IdEmpleadoNavigation)
                //    .WithMany(p => p.Venta)
                //    .HasForeignKey(d => d.IdEmpleado)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK__VENTAS__ID_EMPLE__403A8C7D");

                entity.HasOne(d => d.IdTipoPagoNavigation)
                    .WithMany(p => p.Venta)
                    .HasForeignKey(d => d.IdTipoPago)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VENTAS__ID_TIPO___412EB0B6");
            });

            modelBuilder.Entity<VentasDetalle>(entity =>
            {
                entity.HasKey(e => e.IdVentDetalle)
                    .HasName("PK__VENTAS_D__85D3F4C555C7CF45");

                entity.ToTable("VENTAS_DETALLE");

                entity.Property(e => e.IdVentDetalle).HasColumnName("ID_VENT_DETALLE");

                entity.Property(e => e.Cantidad).HasColumnName("CANTIDAD");

                entity.Property(e => e.IdProducto).HasColumnName("ID_PRODUCTO");

                entity.Property(e => e.IdVenta).HasColumnName("ID_VENTA");

                entity.Property(e => e.ValorTotal).HasColumnName("VALOR_TOTAL");

                entity.Property(e => e.ValorUnit).HasColumnName("VALOR_UNIT");

                entity.HasOne(d => d.IdProductoNavigation)
                    .WithMany(p => p.VentasDetalles)
                    .HasForeignKey(d => d.IdProducto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VENTAS_DE__ID_PR__44FF419A");

                entity.HasOne(d => d.IdVentaNavigation)
                    .WithMany(p => p.VentasDetalles)
                    .HasForeignKey(d => d.IdVenta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VENTAS_DE__ID_VE__440B1D61");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
