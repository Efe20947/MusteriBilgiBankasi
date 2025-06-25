using Microsoft.EntityFrameworkCore;
using MusteriTakip.Models;

namespace MusteriTakip.Data
{
    public class UygulamaDbContext : DbContext
    {
        public UygulamaDbContext(DbContextOptions<UygulamaDbContext> options)
            : base(options)
        {
        }

        public DbSet<Firma> Firmalar { get; set; }
    }
}

