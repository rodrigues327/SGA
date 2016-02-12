using SGA.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SGA.Infrastructure.Data.EntityFramework.EntityMapping
{
    public class AlunoTurmaMap : EntityTypeConfiguration<AlunoTurma>
    {
        public AlunoTurmaMap()
        {
            // Table & Column Mappings
            ToTable("alunosturmas");

            // Primary Key
            HasKey(t => new { t.cd_aluno, t.cd_turma });

            // Properties
            Property(t => t.cd_aluno)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.cd_turma)
                .IsRequired()
                .HasMaxLength(8);

            Property(t => t.cd_alunoexterno)
                .HasMaxLength(11);

            Property(t => t.cd_aluno).HasColumnName("cd_aluno");
            Property(t => t.cd_turma).HasColumnName("cd_turma");
            Property(t => t.datamatricula).HasColumnName("datamatricula");
            Property(t => t.cd_alunoexterno).HasColumnName("cd_alunoexterno");
            Property(t => t.matricula).HasColumnName("matricula");
            Property(t => t.bolsa).HasColumnName("bolsa");
            Property(t => t.obsfinanceiro).HasColumnName("obsfinanceiro");
            Property(t => t.obsdocs).HasColumnName("obsdocs");
            Property(t => t.ativo).HasColumnName("ativo");
            Property(t => t.datainclusao).HasColumnName("datainclusao");
            Property(t => t.usuarioinclusao).HasColumnName("usuarioinclusao");
            Property(t => t.dataalteracao).HasColumnName("dataalteracao");
            Property(t => t.usuarioalteracao).HasColumnName("usuarioalteracao");

            // Relationships
            this.HasRequired(t => t.aluno)
                .WithMany(t => t.Alunosturmas)
                .HasForeignKey(d => d.cd_aluno);
            this.HasRequired(t => t.turma)
                .WithMany(t => t.Alunosturmas)
                .HasForeignKey(d => d.cd_turma);
        }
    }
}