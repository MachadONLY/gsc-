using FuturoTrabalhoApi.Models;
using Microsoft.EntityFrameworkCore;

namespace FuturoTrabalhoApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Habilidade> Habilidades { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed inicial para demonstração
            modelBuilder.Entity<Habilidade>().HasData(
                new Habilidade { Id = 1, Nome = "Inteligência Artificial", Descricao = "Conhecimento em Machine Learning e Deep Learning.", Tipo = "Hard Skill" },
                new Habilidade { Id = 2, Nome = "Pensamento Crítico", Descricao = "Capacidade de analisar informações de forma objetiva.", Tipo = "Soft Skill" },
                new Habilidade { Id = 3, Nome = "Comunicação Intercultural", Descricao = "Habilidade de interagir com pessoas de diferentes culturas.", Tipo = "Soft Skill" }
            );
        }
    }
}
