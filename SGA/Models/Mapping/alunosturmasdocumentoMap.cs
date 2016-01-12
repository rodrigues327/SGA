using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SGA.Models.Mapping
{
    public class alunosturmasdocumentoMap : EntityTypeConfiguration<alunosturmasdocumento>
    {
        public alunosturmasdocumentoMap()
        {
            // Primary Key
            this.HasKey(t => new { t.cd_aluno, t.cd_turma, t.cd_documento });

            // Properties
            this.Property(t => t.cd_aluno)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.cd_turma)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.cd_documento)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("alunosturmasdocumentos");
            this.Property(t => t.cd_aluno).HasColumnName("cd_aluno");
            this.Property(t => t.cd_turma).HasColumnName("cd_turma");
            this.Property(t => t.cd_documento).HasColumnName("cd_documento");
            this.Property(t => t.data).HasColumnName("data");

            // Relationships
            this.HasRequired(t => t.alunosturma)
                .WithMany(t => t.alunosturmasdocumentos)
                .HasForeignKey(d => new { d.cd_aluno, d.cd_turma });
            this.HasRequired(t => t.p002)
                .WithMany(t => t.alunosturmasdocumentos)
                .HasForeignKey(d => d.cd_documento);

        }
    }
}
