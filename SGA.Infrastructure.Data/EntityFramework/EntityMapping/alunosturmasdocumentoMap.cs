using SGA.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SGA.Infrastructure.Data.EntityFramework.EntityMapping
{
    public class AlunosturmasdocumentoMap : EntityTypeConfiguration<AlunoTurmaDocumento>
    {
        public AlunosturmasdocumentoMap()
        {
            // Primary Key
            HasKey(t => new { t.cd_aluno, t.cd_turma, t.cd_documento });

            // Properties
            Property(t => t.cd_aluno)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.cd_turma)
                .IsRequired()
                .HasMaxLength(8);

            Property(t => t.cd_documento)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            ToTable("alunosturmasdocumentos");
            Property(t => t.cd_aluno).HasColumnName("cd_aluno");
            Property(t => t.cd_turma).HasColumnName("cd_turma");
            Property(t => t.cd_documento).HasColumnName("cd_documento");
            Property(t => t.data).HasColumnName("data");

            // Relationships
            this.HasRequired(t => t.alunosturma)
                .WithMany(t => t.alunosturmasdocumentos)
                .HasForeignKey(d => new { d.cd_aluno, d.cd_turma });
            this.HasRequired(t => t.p002)
                .WithMany(t => t.Alunosturmasdocumentos)
                .HasForeignKey(d => d.cd_documento);
        }
    }
}