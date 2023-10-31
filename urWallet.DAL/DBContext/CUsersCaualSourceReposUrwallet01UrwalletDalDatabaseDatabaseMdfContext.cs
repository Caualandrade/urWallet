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

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\caual\\source\\repos\\urWallet.01\\urWallet.DAL\\database\\database.mdf;Integrated Security=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
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
