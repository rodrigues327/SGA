using SGA.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace SGA.Infrastructure.Data.EntityFramework.EntityMapping
{
    public class CursoMap : EntityTypeConfiguration<Curso>
    {
        public CursoMap()
        {
            // Primary Key
            HasKey(t => t.cd_curso);

            // Properties
            Property(t => t.cd_curso)
                .IsRequired()
                .HasMaxLength(2);

            Property(t => t.curso1)
                .HasMaxLength(255);

            // Table & Column Mappings
            ToTable("Cursos");
            Property(t => t.cd_curso).HasColumnName("cd_curso");
            Property(t => t.curso1).HasColumnName("curso");
            Property(t => t.TipocursoId).HasColumnName("cd_tipocurso");
            Property(t => t.numparcelas).HasColumnName("numparcelas");
            Property(t => t.repasse).HasColumnName("repasse");
            Property(t => t.mensalidade).HasColumnName("mensalidade");
            Property(t => t.datainclusao).HasColumnName("datainclusao");
            Property(t => t.usuarioinclusao).HasColumnName("usuarioinclusao");
            Property(t => t.dataalteracao).HasColumnName("dataalteracao");
            Property(t => t.usuarioalteracao).HasColumnName("usuarioalteracao");

            // Relationships
            HasOptional(t => t.tiposcurso)
                .WithMany(t => t.cursos)
                .HasForeignKey(d => d.TipocursoId);
        }
    }
}