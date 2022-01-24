using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DBConfiguration.EFcore
{
    public class SolaresContext : DbContext
    {
        public SolaresContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            if (!dbContextOptionsBuilder.IsConfigured)
            {
                dbContextOptionsBuilder.UseSqlServer(DatabaseConnection
                    .ConnectionConfiguration.GetConnectionString("DefaultConnection"));
            }
        }

        public SolaresContext(DbContextOptions<SolaresContext> options) : base(options) { }
        public DbSet<Aluno> Aluno { get; set; }
        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry =>
            entry.Entity.GetType().GetProperty("DataCriacao") != null ||
            entry.Entity.GetType().GetProperty("DataAtualizacao") != null
            ))
            {

                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataCriacao").CurrentValue = DateTime.Now;
                    entry.Property("DataAtualizacao").CurrentValue = DateTime.Now;
                }
                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataAtualizacao").CurrentValue = DateTime.Now;
                }
            }

            return base.SaveChanges();
        }

    }
}
