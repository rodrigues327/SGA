using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SGA.Models.Mapping
{
    public class formaspagamentoMap : EntityTypeConfiguration<formaspagamento>
    {
        public formaspagamentoMap()
        {
            // Primary Key
            this.HasKey(t => t.cd_formapagamento);

            // Properties
            this.Property(t => t.formapagamento)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("formaspagamentos");
            this.Property(t => t.cd_formapagamento).HasColumnName("cd_formapagamento");
            this.Property(t => t.formapagamento).HasColumnName("formapagamento");
        }
    }
}
