using ContaCorrenteApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ContaCorrenteApi.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<ContaCorrente> contaCorrentes { get; set; }
    }
}