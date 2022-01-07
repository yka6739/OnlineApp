using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using OnlineApp.Business.Entities;
using OnlineApp.Data.Mapper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineApp.Data.Helpers
{
    public class OnlineAppDbContext:DbContext
    {
        private string DbConnStr { get; set; }
        public OnlineAppDbContext()
        {
            IConfigurationBuilder builder = new ConfigurationBuilder();
            builder.AddJsonFile(Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json"));
            var root = builder.Build();
            DbConnStr = root.GetConnectionString("OnlineAppDBConn");
        }
        public OnlineAppDbContext(DbContextOptions<OnlineAppDbContext> options)
         : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(DbConnStr);

        }
        public DbSet<Individual> IndividualSet { get; set; }
        public DbSet<VW_Individual> IndividualVWSet { get; set; }
        public DbSet<Education> EducationSet { get; set; }
        public DbSet<Country> CountrySet { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new IndividualConfiguration());
            modelBuilder.ApplyConfiguration(new VW_IndividualConfiguration());
            modelBuilder.ApplyConfiguration(new EducationConfiguration());
            modelBuilder.ApplyConfiguration(new CountryConfiguration());


        }

    }
}
