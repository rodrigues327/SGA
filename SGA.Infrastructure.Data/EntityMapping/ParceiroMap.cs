using System.Data.Entity.ModelConfiguration;
using SGA.Domain.Entities;

namespace SGA.Infrastructure.Data.EntityMapping
{
    public class ParceiroMap : EntityTypeConfiguration<Parceiro>
    {
        public ParceiroMap()
        {
            // Primary Key
            HasKey(t => t.cd_parceiro);

            // Properties
            Property(t => t.parceiro1)
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("parceiros");
            Property(t => t.cd_parceiro).HasColumnName("cd_parceiro");
            Property(t => t.parceiro1).HasColumnName("parceiro");
            Property(t => t.datainclusao).HasColumnName("datainclusao");
            Property(t => t.usuarioinclusao).HasColumnName("usuarioinclusao");
            Property(t => t.dataalteracao).HasColumnName("dataalteracao");
            Property(t => t.usuarioalteracao).HasColumnName("usuarioalteracao");
        }
    }
}