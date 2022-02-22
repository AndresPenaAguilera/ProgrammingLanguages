using Microsoft.EntityFrameworkCore;

namespace EntityFramework
{
    public partial class AppCursosContext : DbContext
    {
        private const string connectionString = @"Data Source=GTH-93\SQLEXPRESS; Initial Catalog=CursosOnline;User ID=sa;Password=Sinco123;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<CursoInstructor>().HasKey(ci=> new { ci.CursoId, ci.InstructorId });
        }

        public DbSet<Curso> Curso { get; set; }
        public DbSet<Comentario> Comentario { get; set; }
        public DbSet<Instructor> Instructor { get; set; }
        public DbSet<CursoInstructor> CursoInstructor { get; set; }

        public void GuardarCambios() 
        {
            SaveChanges();
        }
    }
}
