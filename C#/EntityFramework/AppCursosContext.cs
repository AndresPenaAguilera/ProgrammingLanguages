using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    public class AppCursosContext : DbContext
    {
        private const string connectionString = @"Data Source=GTH-93\SQLEXPRESS; Initial Catalog=CursosOnline;User ID=sa;Password=Sinco123;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            optionsBuilder.UseSqlServer(connectionString);
        }

        public DbSet<Curso> Curso { get; set; }
    }
}
