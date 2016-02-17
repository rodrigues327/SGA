using SGA.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace SGA.Infrastructure.Data.EntityFramework.EntityMapping
{
    public class P002Map : EntityTypeConfiguration<P002>
    {
        public P002Map()
        {
            // Primary Key
            this.HasKey(t => t.CdDocumento);

            // Properties
            this.Property(t => t.Documento)
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("p002");
            this.Property(t => t.CdDocumento).HasColumnName("cd_documento");
            this.Property(t => t.Documento).HasColumnName("documento");
            this.Property(t => t.CdTipocurso).HasColumnName("cd_tipocurso");
            this.Property(t => t.Ordem).HasColumnName("ordem");

            // Relationships
            this.HasOptional(t => t.Tiposcurso)
                .WithMany(t => t.p002)
                .HasForeignKey(d => d.CdTipocurso);
        }
    }
}