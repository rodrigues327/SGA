using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SGA.Models.Mapping
{
    public class cursosdisciplinaMap : EntityTypeConfiguration<cursosdisciplina>
    {
        public cursosdisciplinaMap()
        {
            // Primary Key
            this.HasKey(t => new { t.cd_curso, t.cd_disciplina });

            // Properties
            this.Property(t => t.cd_curso)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.cd_disciplina)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("cursosdisciplinas");
            this.Property(t => t.cd_curso).HasColumnName("cd_curso");
            this.Property(t => t.cd_disciplina).HasColumnName("cd_disciplina");
            this.Property(t => t.datainclusao).HasColumnName("datainclusao");
            this.Property(t => t.usuarioinclusao).HasColumnName("usuarioinclusao");
            this.Property(t => t.dataalteracao).HasColumnName("dataalteracao");
            this.Property(t => t.usuarioalteracao).HasColumnName("usuarioalteracao");
        }
    }
}
