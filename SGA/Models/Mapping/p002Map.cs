using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SGA.Models.Mapping
{
    public class p002Map : EntityTypeConfiguration<p002>
    {
        public p002Map()
        {
            // Primary Key
            this.HasKey(t => t.cd_documento);

            // Properties
            this.Property(t => t.documento)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("p002");
            this.Property(t => t.cd_documento).HasColumnName("cd_documento");
            this.Property(t => t.documento).HasColumnName("documento");
            this.Property(t => t.cd_tipocurso).HasColumnName("cd_tipocurso");
            this.Property(t => t.ordem).HasColumnName("ordem");

            // Relationships
            this.HasOptional(t => t.tiposcurso)
                .WithMany(t => t.p002)
                .HasForeignKey(d => d.cd_tipocurso);

        }
    }
}
