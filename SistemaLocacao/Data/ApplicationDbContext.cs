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
    }
}
