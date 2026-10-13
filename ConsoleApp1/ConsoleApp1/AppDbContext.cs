using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Prueba_Base_de_Datos
{
    internal class AppDbContext : DbContext
    {
        public DbSet<Agente> agentes_valorant => Set<Agente>();

        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString =
                "Server=localhost;Database=EVALUACION;Uid=root;pwd=;";

            var serverVersion =
                ServerVersion.AutoDetect(connectionString);

            optionsBuilder.UseMySql(connectionString, serverVersion);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Agente>().ToTable("agentes_valorant");
            modelBuilder.Entity<Agente>().HasKey(a => a.id);
        }
    }
}

