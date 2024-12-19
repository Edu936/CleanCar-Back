using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanCar.Domain.Entities;
using CleanCar.Infrastructure.Map;
using Microsoft.EntityFrameworkCore;

namespace CleanCar.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Cidade> Cidade { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CidadeMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
