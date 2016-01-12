using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SGA.Models.Mapping
{
    public class vw_reldiarioMap : EntityTypeConfiguration<vw_reldiario>
    {
        public vw_reldiarioMap()
        {
            // Primary Key
            this.HasKey(t => new { t.data, t.cd_turma, t.cd_disciplina });

            // Properties
            this.Property(t => t.curso)
                .HasMaxLength(255);

            this.Property(t => t.disciplina)
                .HasMaxLength(100);

            this.Property(t => t.professor)
                .HasMaxLength(50);

            this.Property(t => t.aluno)
                .HasMaxLength(50);

            this.Property(t => t.turma)
                .HasMaxLength(50);

            this.Property(t => t.cd_turma)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.cd_disciplina)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("vw_reldiario");
            this.Property(t => t.curso).HasColumnName("curso");
            this.Property(t => t.disciplina).HasColumnName("disciplina");
            this.Property(t => t.professor).HasColumnName("professor");
            this.Property(t => t.aluno).HasColumnName("aluno");
            this.Property(t => t.data).HasColumnName("data");
            this.Property(t => t.turma).HasColumnName("turma");
            this.Property(t => t.cd_turma).HasColumnName("cd_turma");
            this.Property(t => t.cd_disciplina).HasColumnName("cd_disciplina");
        }
    }
}
