using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SGA.Models.Mapping
{
    public class vw_relpagamentosturmaMap : EntityTypeConfiguration<vw_relpagamentosturma>
    {
        public vw_relpagamentosturmaMap()
        {
            // Primary Key
            this.HasKey(t => t.cd_turma);

            // Properties
            this.Property(t => t.cd_alunoexterno)
                .HasMaxLength(11);

            this.Property(t => t.nome)
                .HasMaxLength(50);

            this.Property(t => t.cd_turma)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.turma)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("vw_relpagamentosturma");
            this.Property(t => t.cd_alunoexterno).HasColumnName("cd_alunoexterno");
            this.Property(t => t.nome).HasColumnName("nome");
            this.Property(t => t.cd_turma).HasColumnName("cd_turma");
            this.Property(t => t.turma).HasColumnName("turma");
            this.Property(t => t.cd_mensalidade).HasColumnName("cd_mensalidade");
            this.Property(t => t.valorpago).HasColumnName("valorpago");
            this.Property(t => t.datapagamento).HasColumnName("datapagamento");
            this.Property(t => t.ativo).HasColumnName("ativo");
        }
    }
}
