using Kafedisyon.Data.KafedisyonMigration;
using Kafedisyon.Model.Entities;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Kafedisyon.Data.Context
{

    public class KafedisyonContext : BaseDbContext<KafedisyonContext,Configuration>
    {
        public KafedisyonContext()
        {
            Configuration.LazyLoadingEnabled = false;
        }

        public KafedisyonContext(string connectionString) : base(connectionString)
        {
            Configuration.LazyLoadingEnabled = false;
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
        }
        public DbSet<Urun> Urun { get; set; }
        public DbSet<Kategori> Kategori { get; set; }
        public DbSet<Bolum> Bolum { get; set; }
        public DbSet<Masa> Masa { get; set; }
    }
    

}