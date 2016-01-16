using SGA.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace SGA.Infrastructure.Data.EntityMapping
{
    public class FormaPagamentoMap : EntityTypeConfiguration<FormaPagamento>
    {
        public FormaPagamentoMap()
        {
            // Primary Key
            HasKey(t => t.cd_formapagamento);

            // Properties
            Property(t => t.formapagamento)
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("formaspagamentos");
            Property(t => t.cd_formapagamento).HasColumnName("cd_formapagamento");
            Property(t => t.formapagamento).HasColumnName("formapagamento");
        }
    }
}