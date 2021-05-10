using System.Linq;
using EducaFacil.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace EducaFacil.Infra.Context
{
    public class DataContext : DbContext
    {
        public DataContext() { }
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var property in modelBuilder.Model.GetEntityTypes()
                .SelectMany(e => e.GetProperties()
                    .Where(p => p.ClrType == typeof(string))))
                property.SetColumnType("varchar(100)");

            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.ClientSetNull;
            }

            modelBuilder.Entity<AlunoCurso>().HasKey(sc => new { sc.AlunoId, sc.CursoId });
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DataContext).Assembly);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Assinatura> Assinaturas { get; set; }
        public DbSet<Aula> Aulas { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Modulo> Modulos { get; set; }
        public DbSet<Pagamento> Pagamentos { get; set; }
        public DbSet<AlunoCurso> AlunoCursos { get; set; }
    
}
}
