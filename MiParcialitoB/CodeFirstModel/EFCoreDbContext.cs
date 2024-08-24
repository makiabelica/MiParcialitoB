using Microsoft.EntityFrameworkCore;

namespace MiParcialitoB.CodeFirstModel
{
    public class EFCoreDbContext : DbContext
    {
        public DbSet<Estudiante> Estudiantes { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Inscripcion> Inscripciones { get; set; }

        // Constructor sin parámetros para operaciones de diseño
        public EFCoreDbContext()
        {
        }

        // Constructor que acepta opciones
        public EFCoreDbContext(DbContextOptions<EFCoreDbContext> options)
            : base(options)
        {
        }

        // Configuración del contexto
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var connectionString = "Server=qa.negociostecnologicos.net;Port=3306;Database=EC100521;User=desarrolloWebUfg;Password=<BTj$jrrLV2~-4Yp1vT-;";
                optionsBuilder.UseMySql(connectionString, new MySqlServerVersion(new Version(8, 0, 27))); // Ajusta la versión según tu versión de MySQL
            }
        }

        // Configuración del modelo
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Inscripcion>()
                .HasKey(i => new { i.EstudianteID, i.CursoID });

            modelBuilder.Entity<Inscripcion>()
                .HasOne(i => i.Estudiante)
                .WithMany(e => e.Inscripciones)
                .HasForeignKey(i => i.EstudianteID)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Inscripcion>()
                .HasOne(i => i.Curso)
                .WithMany(c => c.Inscripciones)
                .HasForeignKey(i => i.CursoID)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
