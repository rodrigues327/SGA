using SGA.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SGA.Infrastructure.Data.EntityMapping
{
    public class AlunosturmasdisciplinaMap : EntityTypeConfiguration<AlunoTurmaDisciplina>
    {
        public AlunosturmasdisciplinaMap()
        {
            // Primary Key
            HasKey(t => new { t.cd_aluno, t.cd_turma, t.cd_disciplina });

            // Properties
            Property(t => t.cd_aluno)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.cd_turma)
                .IsRequired()
                .HasMaxLength(8);

            Property(t => t.cd_disciplina)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            ToTable("alunosturmasdisciplinas");
            Property(t => t.cd_aluno).HasColumnName("cd_aluno");
            Property(t => t.cd_turma).HasColumnName("cd_turma");
            Property(t => t.cd_disciplina).HasColumnName("cd_disciplina");
            Property(t => t.presenca).HasColumnName("presenca");
            Property(t => t.nota).HasColumnName("nota");
            Property(t => t.datainclusao).HasColumnName("datainclusao");
            Property(t => t.usuarioinclusao).HasColumnName("usuarioinclusao");
            Property(t => t.dataalteracao).HasColumnName("dataalteracao");
            Property(t => t.usuarioalteracao).HasColumnName("usuarioalteracao");

            // Relationships
            this.HasRequired(t => t.aluno)
                .WithMany(t => t.Alunosturmasdisciplinas)
                .HasForeignKey(d => d.cd_aluno);
            this.HasRequired(t => t.alunosturma)
                .WithMany(t => t.alunosturmasdisciplinas)
                .HasForeignKey(d => new { d.cd_aluno, d.cd_turma });
            this.HasRequired(t => t.TurmaDisciplina)
                .WithMany(t => t.Alunosturmasdisciplinas)
                .HasForeignKey(d => new { d.cd_turma, d.cd_disciplina });
        }
    }
}