using SGA.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace SGA.Infrastructure.Data.EntityFramework.EntityMapping
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