using API_ECCUSBET.Core.Entities;
using ECCUSBET_Web.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ECCUSBET_Web.Models.Repository
{
    public class ApplicationContext : DbContext
    {

        public ApplicationContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Definição de PK
            modelBuilder.Entity<TbDimensionamento>().HasKey(t => t.Id);
            modelBuilder.Entity<TbOrcamento>().HasKey(t => t.Id);
            modelBuilder.Entity<TbCustoTotal>().HasKey(t => t.Id);

            //Definindo relacionamento
            modelBuilder.Entity<TbDimensionamento>().HasOne(t => t.TbCustoTotal);
        }
    }
}
