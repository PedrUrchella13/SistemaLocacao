using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SistemaLocacao.Models;

namespace SistemaLocacao.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<SistemaLocacao.Models.Filme> Filme { get; set; } = default!;
        public DbSet<SistemaLocacao.Models.Cliente> Cliente { get; set; } = default!;
        public DbSet<SistemaLocacao.Models.Movimentacao> Movimentacao { get; set; } = default!;
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Movimentacao>()
                .HasOne(m => m.Cliente)
                .WithMany()
                .HasForeignKey(m => m.ClienteId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<Movimentacao>()
                .HasOne(m => m.Filme)
                .WithMany()
                .HasForeignKey(m => m.FilmeId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
