using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Fotografia.Infrastructure.Entities;

namespace Fotografia.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option) : base(option)
        {

        }

        public DbSet<Servicos> Servico { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);

            _ = modelBuilder.Entity<Servicos>().HasData(
                new Servicos
                {
                    Id = 1,
                    Name = "Portrait",
                    Description = "Does...",
                    Price = 30,
                    ImageUrl = "",
                },
                new Servicos
                {
                    Id = 2,
                    Name = "Wedding",
                    Description = "Does...",
                    Price = 50,
                    ImageUrl = "",
                },
                new Servicos
                {
                    Id = 3,
                    Name = "Animals",
                    Description = "Does...",
                    Price = 10,
                    ImageUrl = "",
                }

                ) ;
        }
    }
}