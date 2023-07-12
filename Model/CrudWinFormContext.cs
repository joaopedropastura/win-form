using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace winForms.Model;

public partial class CrudWinFormContext : DbContext
{
    public CrudWinFormContext()
    {
    }

    public CrudWinFormContext(DbContextOptions<CrudWinFormContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Estoque> Estoques { get; set; }

    public virtual DbSet<Produto> Produtos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=CT-C-00188\\SQLEXPRESS;Initial Catalog=crudWinForm;Integrated Security=True;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Estoque>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ESTOQUE__3214EC275EF5644F");

            entity.ToTable("ESTOQUE");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ProdutoId).HasColumnName("PRODUTO_ID");
            entity.Property(e => e.Quantidade).HasColumnName("QUANTIDADE");

            entity.HasOne(d => d.Produto).WithMany(p => p.Estoques)
                .HasForeignKey(d => d.ProdutoId)
                .HasConstraintName("FK__ESTOQUE__PRODUTO__398D8EEE");
        });

        modelBuilder.Entity<Produto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PRODUTO__3214EC27F58A817E");

            entity.ToTable("PRODUTO");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.Preco)
                .HasColumnType("money")
                .HasColumnName("PRECO");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
