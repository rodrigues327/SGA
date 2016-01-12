using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SGA.Models.Mapping
{
    public class turmasdisciplinaMap : EntityTypeConfiguration<turmasdisciplina>
    {
        public turmasdisciplinaMap()
        {
            // Primary Key
            this.HasKey(t => new { t.cd_turma, t.cd_disciplina });

            // Properties
            this.Property(t => t.cd_turma)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.cd_disciplina)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("turmasdisciplinas");
            this.Property(t => t.cd_turma).HasColumnName("cd_turma");
            this.Property(t => t.cd_disciplina).HasColumnName("cd_disciplina");
            this.Property(t => t.datainclusao).HasColumnName("datainclusao");
            this.Property(t => t.usuarioinclusao).HasColumnName("usuarioinclusao");
            this.Property(t => t.dataalteracao).HasColumnName("dataalteracao");
            this.Property(t => t.usuarioalteracao).HasColumnName("usuarioalteracao");

            // Relationships
            this.HasRequired(t => t.disciplina)
                .WithMany(t => t.turmasdisciplinas)
                .HasForeignKey(d => d.cd_disciplina);

        }
    }
}
