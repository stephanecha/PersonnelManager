using System.Data.Entity;

namespace PersonnelManager.Data.Context
{
    public class DataContext : DbContext
    {
        public DataContext() : base("ConnexionBD")
        {
        }

        public DbSet<Cadre> Cadres { get; set; }

        public DbSet<Ouvrier> Ouvriers { get; set; }

        public DbSet<ReleveMensuel> RelevesMensuels { get; set; }

        public DbSet<ReleveJour> RelevesJours { get; set; }

        public DbSet<Periode> Periodes { get; set; }
    }
}
