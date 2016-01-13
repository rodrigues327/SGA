using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SGA.Models.Mapping
{
    public class turmasdisciplinascalendarioMap : EntityTypeConfiguration<turmasdisciplinascalendario>
    {
        public turmasdisciplinascalendarioMap()
        {
            // Primary Key
            this.HasKey(t => new { t.cd_turma, t.cd_disciplina, t.data });

            // Properties
            this.Property(t => t.cd_turma)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.cd_disciplina)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("turmasdisciplinascalendario");
            this.Property(t => t.cd_turma).HasColumnName("cd_turma");
            this.Property(t => t.cd_disciplina).HasColumnName("cd_disciplina");
            this.Property(t => t.data).HasColumnName("data");
            this.Property(t => t.cd_professor).HasColumnName("cd_professor");
            this.Property(t => t.datainclusao).HasColumnName("datainclusao");
            this.Property(t => t.usuarioinclusao).HasColumnName("usuarioinclusao");
            this.Property(t => t.dataalteracao).HasColumnName("dataalteracao");
            this.Property(t => t.usuarioalteracao).HasColumnName("usuarioalteracao");

            // Relationships
            this.HasOptional(t => t.professore)
                .WithMany(t => t.turmasdisciplinascalendarios)
                .HasForeignKey(d => d.cd_professor);
            this.HasRequired(t => t.turmasdisciplina)
                .WithMany(t => t.turmasdisciplinascalendarios)
                .HasForeignKey(d => new { d.cd_turma, d.cd_disciplina });

        }
    }
}
