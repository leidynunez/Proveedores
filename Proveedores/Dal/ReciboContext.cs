using Proveedores.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Proveedores.Dal
{
    public class ReciboContext : DbContext
    {
        public ReciboContext() : base("ReciboContext")
        {
        }

        public DbSet<recibos> Students { get; set; }
     

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}