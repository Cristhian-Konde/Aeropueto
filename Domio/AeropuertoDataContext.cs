using Domio.Entities;
using Microsoft.EntityFrameworkCore;

namespace Domio
{
    public class AeropuertoDataContext : DbContext
    {
        public AeropuertoDataContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AeropuertoDataContext).Assembly);
        }

        #region DbSets
        public DbSet<MovimientosAeropuerto> MovimientosAeropuerto { get; set; }
        #endregion
    }
}