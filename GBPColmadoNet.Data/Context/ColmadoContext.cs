using System;
using System.Collections.Generic;
using GBPColmadoNet.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace GBPColmadoNet.Data.Context;

public partial class ColmadoContext : DbContext
{
    public ColmadoContext()
    {
    }

    public ColmadoContext(DbContextOptions<ColmadoContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Abono> Abonos { get; set; }

    public virtual DbSet<Bitacora> Bitacoras { get; set; }

    public virtual DbSet<Categoria> Categorias { get; set; }

    public virtual DbSet<CierresCaja> CierresCajas { get; set; }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<Compra> Compras { get; set; }

    public virtual DbSet<ComprasDetalle> ComprasDetalles { get; set; }

    public virtual DbSet<CuentasPorCobrar> CuentasPorCobrars { get; set; }

    public virtual DbSet<Producto> Productos { get; set; }

    public virtual DbSet<Proveedore> Proveedores { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    public virtual DbSet<Venta> Ventas { get; set; }

    public virtual DbSet<VentasDetalle> VentasDetalles { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=GBPColmadoDB;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Abono>(entity =>
        {
            entity.HasKey(e => e.AbonoId).HasName("PK__Abonos__0038E98AC6D30B76");

            entity.Property(e => e.Fecha)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Monto).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.CuentaPorCobrar).WithMany(p => p.Abonos)
                .HasForeignKey(d => d.CuentaPorCobrarId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Abonos__CuentaPo__19DFD96B");

            entity.HasOne(d => d.Usuario).WithMany(p => p.Abonos)
                .HasForeignKey(d => d.UsuarioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Abonos__UsuarioI__1AD3FDA4");
        });

        modelBuilder.Entity<Bitacora>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Bitacora__3214EC07FC14A725");

            entity.ToTable("Bitacora");

            entity.Property(e => e.Accion).HasMaxLength(100);
            entity.Property(e => e.Fecha)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Modulo).HasMaxLength(50);

            entity.HasOne(d => d.Usuario).WithMany(p => p.Bitacoras)
                .HasForeignKey(d => d.UsuarioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Bitacora__Usuari__25518C17");
        });

        modelBuilder.Entity<Categoria>(entity =>
        {
            entity.HasKey(e => e.CategoriaId).HasName("PK__Categori__F353C1E518F5D3D0");

            entity.Property(e => e.FechaModificacion).HasColumnType("datetime");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Nombre).HasMaxLength(50);
        });

        modelBuilder.Entity<CierresCaja>(entity =>
        {
            entity.HasKey(e => e.CierreId).HasName("PK__CierresC__0BAD3FBAAC6E5689");

            entity.ToTable("CierresCaja");

            entity.Property(e => e.AbonosRecibidos)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Diferencia)
                .HasComputedColumnSql("([MontoRealEntregado]-[MontoFinalEsperado])", false)
                .HasColumnType("decimal(19, 2)");
            entity.Property(e => e.Estado)
                .HasMaxLength(20)
                .HasDefaultValue("Abierto");
            entity.Property(e => e.FechaApertura).HasColumnType("datetime");
            entity.Property(e => e.FechaCierre).HasColumnType("datetime");
            entity.Property(e => e.MontoFinalEsperado).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.MontoInicial).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.MontoRealEntregado).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.VentasCredito)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.VentasEfectivo)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Usuario).WithMany(p => p.CierresCajas)
                .HasForeignKey(d => d.UsuarioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CierresCa__Usuar__2180FB33");
        });

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.ClienteId).HasName("PK__Clientes__71ABD0878150900E");

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.FechaModificacion).HasColumnType("datetime");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Nombre).HasMaxLength(100);
            entity.Property(e => e.Telefono).HasMaxLength(20);
        });

        modelBuilder.Entity<Compra>(entity =>
        {
            entity.HasKey(e => e.CompraId).HasName("PK__Compras__067DA7457376CA34");

            entity.Property(e => e.Fecha)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FechaModificacion).HasColumnType("datetime");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.TotalItbis)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TotalITBIS");
            entity.Property(e => e.TotalNeto).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Proveedor).WithMany(p => p.Compras)
                .HasForeignKey(d => d.ProveedorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Compras__Proveed__10566F31");

            entity.HasOne(d => d.Usuario).WithMany(p => p.Compras)
                .HasForeignKey(d => d.UsuarioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Compras__Usuario__114A936A");
        });

        modelBuilder.Entity<ComprasDetalle>(entity =>
        {
            entity.HasKey(e => e.DetalleId).HasName("PK__ComprasD__6E19D6DAE8AE5771");

            entity.ToTable("ComprasDetalle");

            entity.Property(e => e.Cantidad).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.PrecioCompra).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Compra).WithMany(p => p.ComprasDetalles)
                .HasForeignKey(d => d.CompraId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ComprasDe__Compr__14270015");

            entity.HasOne(d => d.Producto).WithMany(p => p.ComprasDetalles)
                .HasForeignKey(d => d.ProductoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ComprasDe__Produ__151B244E");
        });

        modelBuilder.Entity<CuentasPorCobrar>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CuentasP__3214EC072332A8FD");

            entity.ToTable("CuentasPorCobrar");

            entity.Property(e => e.BalancePendiente)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DiasCredito).HasDefaultValue(15);
            entity.Property(e => e.Estado)
                .HasMaxLength(20)
                .HasDefaultValue("Pendiente");
            entity.Property(e => e.FechaModificacion).HasColumnType("datetime");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FechaVencimiento).HasColumnType("datetime");
            entity.Property(e => e.MontoAbonado)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.MontoDeuda).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Cliente).WithMany(p => p.CuentasPorCobrars)
                .HasForeignKey(d => d.ClienteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CuentasPo__Clien__0A9D95DB");

            entity.HasOne(d => d.Venta).WithMany(p => p.CuentasPorCobrars)
                .HasForeignKey(d => d.VentaId)
                .HasConstraintName("FK__CuentasPo__Venta__0B91BA14");
        });

        modelBuilder.Entity<Producto>(entity =>
        {
            entity.HasKey(e => e.ProductoId).HasName("PK__Producto__A430AEA3DB3AD134");

            entity.HasIndex(e => e.CodigoBarras, "UQ__Producto__F61589C8C52A37C0").IsUnique();

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.CodigoBarras).HasMaxLength(50);
            entity.Property(e => e.FechaModificacion).HasColumnType("datetime");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Nombre).HasMaxLength(100);
            entity.Property(e => e.PrecioCompra).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PrecioVenta).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Stock)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 3)");
            entity.Property(e => e.TasaItbis)
                .HasDefaultValue(18.00m)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("TasaITBIS");

            entity.HasOne(d => d.Categoria).WithMany(p => p.Productos)
                .HasForeignKey(d => d.CategoriaId)
                .HasConstraintName("FK__Productos__Categ__5629CD9C");

            entity.HasOne(d => d.Proveedor).WithMany(p => p.Productos)
                .HasForeignKey(d => d.ProveedorId)
                .HasConstraintName("FK__Productos__Prove__571DF1D5");
        });

        modelBuilder.Entity<Proveedore>(entity =>
        {
            entity.HasKey(e => e.ProveedorId).HasName("PK__Proveedo__61266A59C49B9362");

            entity.Property(e => e.FechaModificacion).HasColumnType("datetime");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Nombre).HasMaxLength(100);
            entity.Property(e => e.Rnc)
                .HasMaxLength(20)
                .HasColumnName("RNC");
            entity.Property(e => e.Telefono).HasMaxLength(20);
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.RolId).HasName("PK__Roles__F92302F1540796D8");

            entity.HasIndex(e => e.Nombre, "UQ__Roles__75E3EFCF25872476").IsUnique();

            entity.Property(e => e.Nombre).HasMaxLength(50);
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.UsuarioId).HasName("PK__Usuarios__2B3DE7B8D62F41B4");

            entity.HasIndex(e => e.Username, "UQ__Usuarios__536C85E4B6AD73C9").IsUnique();

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.FechaModificacion).HasColumnType("datetime");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Rol).HasMaxLength(20);
            entity.Property(e => e.Username).HasMaxLength(50);

            entity.HasMany(d => d.Rols).WithMany(p => p.Usuarios)
                .UsingEntity<Dictionary<string, object>>(
                    "UsuarioRole",
                    r => r.HasOne<Role>().WithMany()
                        .HasForeignKey("RolId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__UsuarioRo__RolId__2DE6D218"),
                    l => l.HasOne<Usuario>().WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__UsuarioRo__Usuar__2CF2ADDF"),
                    j =>
                    {
                        j.HasKey("UsuarioId", "RolId").HasName("PK__UsuarioR__24AFD7977837963E");
                        j.ToTable("UsuarioRoles");
                    });
        });

        modelBuilder.Entity<Venta>(entity =>
        {
            entity.HasKey(e => e.VentaId).HasName("PK__Ventas__5B4150AC39DD5EC8");

            entity.Property(e => e.Fecha)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.TotalItbis)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TotalITBIS");
            entity.Property(e => e.TotalNeto).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Cliente).WithMany(p => p.Venta)
                .HasForeignKey(d => d.ClienteId)
                .HasConstraintName("FK__Ventas__ClienteI__5FB337D6");

            entity.HasOne(d => d.Usuario).WithMany(p => p.Venta)
                .HasForeignKey(d => d.UsuarioId)
                .HasConstraintName("FK__Ventas__UsuarioI__5EBF139D");
        });

        modelBuilder.Entity<VentasDetalle>(entity =>
        {
            entity.HasKey(e => e.DetalleId).HasName("PK__VentasDe__6E19D6DA816C1A49");

            entity.ToTable("VentasDetalle");

            entity.Property(e => e.Cantidad).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.PrecioUnitario).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Producto).WithMany(p => p.VentasDetalles)
                .HasForeignKey(d => d.ProductoId)
                .HasConstraintName("FK__VentasDet__Produ__6383C8BA");

            entity.HasOne(d => d.Venta).WithMany(p => p.VentasDetalles)
                .HasForeignKey(d => d.VentaId)
                .HasConstraintName("FK__VentasDet__Venta__628FA481");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
