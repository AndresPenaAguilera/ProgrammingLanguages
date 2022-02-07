using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace leerData
{
    public class AppVentaCursosContext : DbContext
    {
        private const string connectionString =@"Data Source=GTH-93\SQLEXPRESS; Initial Catalog=CursosOnline;User ID=sa;Password=Sinco123;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }

        public DbSet<Curso> Curso {get; set;}
        public DbSet<Precio> Precio {get; set;}
        public DbSet<Comentario> Comentario {get; set;}
    }
}