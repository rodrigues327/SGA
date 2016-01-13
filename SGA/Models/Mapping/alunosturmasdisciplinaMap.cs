using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SGA.Models.Mapping
{
    public class alunosturmasdisciplinaMap : EntityTypeConfiguration<alunosturmasdisciplina>
    {
        public alunosturmasdisciplinaMap()
        {
            // Primary Key
            this.HasKey(t => new { t.cd_aluno, t.cd_turma, t.cd_disciplina });

            // Properties
            this.Property(t => t.cd_aluno)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.cd_turma)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.cd_disciplina)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("alunosturmasdisciplinas");
            this.Property(t => t.cd_aluno).HasColumnName("cd_aluno");
            this.Property(t => t.cd_turma).HasColumnName("cd_turma");
            this.Property(t => t.cd_disciplina).HasColumnName("cd_disciplina");
            this.Property(t => t.presenca).HasColumnName("presenca");
            this.Property(t => t.nota).HasColumnName("nota");
            this.Property(t => t.datainclusao).HasColumnName("datainclusao");
            this.Property(t => t.usuarioinclusao).HasColumnName("usuarioinclusao");
            this.Property(t => t.dataalteracao).HasColumnName("dataalteracao");
            this.Property(t => t.usuarioalteracao).HasColumnName("usuarioalteracao");

            // Relationships
            this.HasRequired(t => t.aluno)
                .WithMany(t => t.alunosturmasdisciplinas)
                .HasForeignKey(d => d.cd_aluno);
            this.HasRequired(t => t.alunosturma)
                .WithMany(t => t.alunosturmasdisciplinas)
                .HasForeignKey(d => new { d.cd_aluno, d.cd_turma });
            this.HasRequired(t => t.turmasdisciplina)
                .WithMany(t => t.alunosturmasdisciplinas)
                .HasForeignKey(d => new { d.cd_turma, d.cd_disciplina });

        }
    }
}
