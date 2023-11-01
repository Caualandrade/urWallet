using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using urWallet.MODEL;
namespace urWallet.DAL.DBContext;

public partial class CUsersCaualSourceReposUrwallet01UrwalletDalDatabaseDatabaseMdfContext : DbContext
{
    public CUsersCaualSourceReposUrwallet01UrwalletDalDatabaseDatabaseMdfContext()
    {
    }

    public CUsersCaualSourceReposUrwallet01UrwalletDalDatabaseDatabaseMdfContext(DbContextOptions<CUsersCaualSourceReposUrwallet01UrwalletDalDatabaseDatabaseMdfContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Financa> Financas { get; set; }

    public virtual DbSet<UserFinanca> UserFinancas { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\caual\\source\\repos\\urWallet.01\\urWallet.DAL\\database\\database.mdf;Integrated Security=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Financa>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__financas__3214EC07AA302CC7");

            entity.ToTable("financas");

            entity.Property(e => e.Categoria)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("categoria");
            entity.Property(e => e.Data)
                .HasColumnType("date")
                .HasColumnName("data");
            entity.Property(e => e.Descricao)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("descricao");
            entity.Property(e => e.Tipo)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("tipo");
            entity.Property(e => e.Valor)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("valor");
        });

        modelBuilder.Entity<UserFinanca>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__userFina__3214EC07C0ACA133");

            entity.ToTable("userFinanca");

            entity.Property(e => e.IdFinanca).HasColumnName("id_financa");
            entity.Property(e => e.IdUser).HasColumnName("id_user");

            entity.HasOne(d => d.IdFinancaNavigation).WithMany(p => p.UserFinancas)
                .HasForeignKey(d => d.IdFinanca)
                .HasConstraintName("FK__userFinan__id_fi__5CD6CB2B");

            entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.UserFinancas)
                .HasForeignKey(d => d.IdUser)
                .HasConstraintName("FK__userFinan__id_us__5DCAEF64");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Usuarios__3214EC0732258A22");

            entity.Property(e => e.Saldo)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("saldo");
            entity.Property(e => e.Senha)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("senha");
            entity.Property(e => e.user)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("usuario");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
