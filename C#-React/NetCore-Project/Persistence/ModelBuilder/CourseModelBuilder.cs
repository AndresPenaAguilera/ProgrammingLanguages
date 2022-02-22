using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence
{
    public class CourseModelBuilder : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> modelBuilder)
        {
            modelBuilder.ToTable("Curso", "dbo");
            modelBuilder.HasKey(propiedad => new { propiedad.CourseId });
            modelBuilder.Property(propiedad => propiedad.CourseId).HasColumnName("CursoId");
            modelBuilder.Property(propiedad => propiedad.Title).HasColumnName("Titulo");
            modelBuilder.Property(propiedad => propiedad.Description).HasColumnName("Descripcion");
            modelBuilder.Property(propiedad => propiedad.PublicationDate).HasColumnName("FechaPublicacion");
            modelBuilder.Property(propiedad => propiedad.CoverPhoto).HasColumnName("FotoPublicacion");
        }
    }
}