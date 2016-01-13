using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SGA.Models.Mapping
{
    public class vw_relpagamentosMap : EntityTypeConfiguration<vw_relpagamentos>
    {
        public vw_relpagamentosMap()
        {
            // Primary Key
            this.HasKey(t => new { t.cd_turma, t.cd_mensalidade });

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

            this.Property(t => t.local)
                .HasMaxLength(50);

            this.Property(t => t.cd_mensalidade)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.formapagamento)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("vw_relpagamentos");
            this.Property(t => t.cd_alunoexterno).HasColumnName("cd_alunoexterno");
            this.Property(t => t.nome).HasColumnName("nome");
            this.Property(t => t.cd_turma).HasColumnName("cd_turma");
            this.Property(t => t.turma).HasColumnName("turma");
            this.Property(t => t.local).HasColumnName("local");
            this.Property(t => t.cd_mensalidade).HasColumnName("cd_mensalidade");
            this.Property(t => t.numdocumento).HasColumnName("numdocumento");
            this.Property(t => t.datavencimento).HasColumnName("datavencimento");
            this.Property(t => t.valor).HasColumnName("valor");
            this.Property(t => t.desconto).HasColumnName("desconto");
            this.Property(t => t.datapagamento).HasColumnName("datapagamento");
            this.Property(t => t.valorpago).HasColumnName("valorpago");
            this.Property(t => t.formapagamento).HasColumnName("formapagamento");
        }
    }
}
