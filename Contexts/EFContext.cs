using LivroASPdotNETMVC5.Models;
using Microsoft.EntityFrameworkCore;

namespace LivroASPdotNETMVC5.Contexts
{
    public class EFContext : DbContext
    {
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Fabricante> Fabricantes { get; set; }

        public EFContext(DbContextOptions<EFContext> options) : base(options)
        {
            
        }
    }
}