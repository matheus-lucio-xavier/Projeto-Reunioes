using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SistemaReservas.Models;

namespace SistemaReservas.Contexts
{
    public class AppDbContext : DbContext
    {

        private string _connectionString = "Server=localhost;Port=5432;Database=SistemaReservas;User Id=postgres;Password=8643;"; // substituir de acordo com a maquina
        public AppDbContext(DbContextOptions opt) : base(opt)
        {}

        public DbSet<SalaModel> Salas => Set<SalaModel>();
        public DbSet<ReservaModel> Reservas => Set<ReservaModel>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var entitySala = modelBuilder.Entity<SalaModel>();
            var entityReserva = modelBuilder.Entity<ReservaModel>();

            // mapeamento
            entitySala.ToTable("salas");
            entitySala.Property(s => s.Id).HasColumnName("id");
            entitySala.Property(s => s.Nome).HasColumnName("nome");
            entitySala.Property(s => s.Andar).HasColumnName("andar");
            entitySala.Property(s => s.qtdAssentos).HasColumnName("qtdassentos");
            entitySala.Property(s => s.Status).HasColumnName("status");
            entitySala.HasKey(s => s.Id);

            entityReserva.ToTable("reservas");
            entityReserva.Property(r => r.Id).HasColumnName("id");
            entityReserva.Property(r => r.Nome).HasColumnName("nome");
            entityReserva.Property(r => r.Inicio).HasColumnName("inicio");
            entityReserva.Property(r => r.Fim).HasColumnName("fim");
            entityReserva.Property(r => r.Status).HasColumnName("status");
            entityReserva.Property(r => r.SalaId).HasColumnName("salaid");
            entityReserva.HasKey(r => r.Id);

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!string.IsNullOrEmpty(_connectionString))
            {
                optionsBuilder.UseNpgsql(_connectionString)
                    .LogTo(message => Debug.WriteLine(message))
                    .EnableSensitiveDataLogging()
                    .EnableDetailedErrors();
            }
            base.OnConfiguring(optionsBuilder);
        }
    }
}