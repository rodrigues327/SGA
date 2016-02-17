using SGA.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace SGA.Infrastructure.Data.EntityFramework.EntityMapping
{
    public class localMap : EntityTypeConfiguration<Local>
    {
        public localMap()
        {
            // Primary Key
            HasKey(t => t.cd_local);

            // Properties
            Property(t => t.cd_local)
                .IsRequired()
                .HasMaxLength(2);

            Property(t => t.local)
                .HasMaxLength(50);

            Property(t => t.estado)
                .HasMaxLength(2);

            // Table & Column Mappings
            ToTable("locais");
            Property(t => t.cd_local).HasColumnName("cd_local");
            Property(t => t.local).HasColumnName("local");
            Property(t => t.estado).HasColumnName("estado");
            Property(t => t.datainclusao).HasColumnName("datainclusao");
            Property(t => t.usuarioinclusao).HasColumnName("usuarioinclusao");
            Property(t => t.dataalteracao).HasColumnName("dataalteracao");
            Property(t => t.usuarioalteracao).HasColumnName("usuarioalteracao");
        }
    }
}