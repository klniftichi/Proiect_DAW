using Microsoft.EntityFrameworkCore;
using Proiect_DAW___Iftichi_Calin.Models;

namespace Proiect_DAW___Iftichi_Calin.Data
{
    public class ProiectContext : DbContext
    {
        public DbSet<Companie> Companii { get; set; }
        public DbSet<Utilizator> Utilizatori { get; set; }
        public DbSet<Job> Joburi { get; set; }
        public DbSet<Sediu> Sedii { get; set; }

        public ProiectContext(DbContextOptions<ProiectContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //FLUENTAPI

            //ONETOMANY
            modelBuilder.Entity<Companie>()
                .HasMany(comp => comp.Joburi)
                .WithOne(j => j.Companie);


            //MANYTOMANY Utilizator -> Job
            modelBuilder.Entity<Aplicatie>()
                .HasKey(RUJ => new { RUJ.UtilizatorId, RUJ.JobId });

            modelBuilder.Entity<Aplicatie>()
                .HasOne<Utilizator>(RUJ => RUJ.Utilizator)
                .WithMany(u => u.Aplicatie)
                .HasForeignKey(RUJ => RUJ.UtilizatorId);

            modelBuilder.Entity<Aplicatie>()
                .HasOne<Job>(RUJ => RUJ.Job)
                .WithMany(j => j.Aplicatie)
                .HasForeignKey(RUJ => RUJ.JobId);


            //ONETOONE

            modelBuilder.Entity<Companie>()
                .HasOne(comp => comp.Sediu)
                .WithOne(s => s.Companie)
                .HasForeignKey<Companie>(comp => comp.SediuId);


            base.OnModelCreating(modelBuilder);
        }
    }
}
