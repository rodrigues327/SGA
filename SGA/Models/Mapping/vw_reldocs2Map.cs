using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SGA.Models.Mapping
{
    public class vw_reldocs2Map : EntityTypeConfiguration<vw_reldocs2>
    {
        public vw_reldocs2Map()
        {
            // Primary Key
            this.HasKey(t => new { t.cd_documento, t.cd_aluno, t.cd_turma });

            // Properties
            this.Property(t => t.cd_documento)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.documento)
                .HasMaxLength(50);

            this.Property(t => t.cd_aluno)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.cd_turma)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.cd_alunoexterno)
                .HasMaxLength(11);

            // Table & Column Mappings
            this.ToTable("vw_reldocs2");
            this.Property(t => t.cd_documento).HasColumnName("cd_documento");
            this.Property(t => t.documento).HasColumnName("documento");
            this.Property(t => t.cd_tipocurso).HasColumnName("cd_tipocurso");
            this.Property(t => t.ordem).HasColumnName("ordem");
            this.Property(t => t.cd_aluno).HasColumnName("cd_aluno");
            this.Property(t => t.cd_turma).HasColumnName("cd_turma");
            this.Property(t => t.datamatricula).HasColumnName("datamatricula");
            this.Property(t => t.cd_alunoexterno).HasColumnName("cd_alunoexterno");
            this.Property(t => t.matricula).HasColumnName("matricula");
            this.Property(t => t.bolsa).HasColumnName("bolsa");
            this.Property(t => t.obsfinanceiro).HasColumnName("obsfinanceiro");
            this.Property(t => t.obsdocs).HasColumnName("obsdocs");
            this.Property(t => t.datainclusao).HasColumnName("datainclusao");
            this.Property(t => t.usuarioinclusao).HasColumnName("usuarioinclusao");
            this.Property(t => t.dataalteracao).HasColumnName("dataalteracao");
            this.Property(t => t.usuarioalteracao).HasColumnName("usuarioalteracao");
        }
    }
}
