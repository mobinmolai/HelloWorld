using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

namespace HelloWorld.Models
{
    public partial class HelloWorldContext : DbContext
    {
        private IConfigurationRoot _config;

        public virtual DbSet<Stops> Stops { get; set; }
        public virtual DbSet<Trips> Trips { get; set; }

        public HelloWorldContext(IConfigurationRoot config, DbContextOptions options) : base(options)
        {
            _config = config;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
            optionsBuilder.UseSqlServer(_config["ConnectionStrings:HelloWorldConnection"]);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Stops>(entity =>
            {
                entity.Property(e => e.Arrival).HasColumnType("datetime");

                entity.Property(e => e.Name).HasColumnType("varchar(50)");

                entity.HasOne(d => d.Trip)
                    .WithMany(p => p.Stops)
                    .HasForeignKey(d => d.TripId)
                    .HasConstraintName("FK_Stop_Trip");
            });

            modelBuilder.Entity<Trips>(entity =>
            {
                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.Name).HasColumnType("varchar(50)");

                entity.Property(e => e.UserName).HasColumnType("varchar(50)");
            });
        }
    }
}