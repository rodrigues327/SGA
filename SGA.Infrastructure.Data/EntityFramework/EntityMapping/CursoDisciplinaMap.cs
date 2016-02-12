using SGA.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SGA.Infrastructure.Data.EntityFramework.EntityMapping
{
    public class CursoDisciplinaMap : EntityTypeConfiguration<CursoDisciplina>
    {
        public CursoDisciplinaMap()
        {
            // Primary Key
            HasKey(t => new { t.cd_curso, t.cd_disciplina });

            // Properties
            Property(t => t.cd_curso)
                .IsRequired()
                .HasMaxLength(2);

            Property(t => t.cd_disciplina)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            ToTable("cursosdisciplinas");
            Property(t => t.cd_curso).HasColumnName("cd_curso");
            Property(t => t.cd_disciplina).HasColumnName("cd_disciplina");
            Property(t => t.datainclusao).HasColumnName("datainclusao");
            Property(t => t.usuarioinclusao).HasColumnName("usuarioinclusao");
            Property(t => t.dataalteracao).HasColumnName("dataalteracao");
            Property(t => t.usuarioalteracao).HasColumnName("usuarioalteracao");
        }
    }
}