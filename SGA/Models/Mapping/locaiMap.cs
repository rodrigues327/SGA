using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SGA.Models.Mapping
{
    public class locaiMap : EntityTypeConfiguration<locai>
    {
        public locaiMap()
        {
            // Primary Key
            this.HasKey(t => t.cd_local);

            // Properties
            this.Property(t => t.cd_local)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.local)
                .HasMaxLength(50);

            this.Property(t => t.estado)
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("locais");
            this.Property(t => t.cd_local).HasColumnName("cd_local");
            this.Property(t => t.local).HasColumnName("local");
            this.Property(t => t.estado).HasColumnName("estado");
            this.Property(t => t.datainclusao).HasColumnName("datainclusao");
            this.Property(t => t.usuarioinclusao).HasColumnName("usuarioinclusao");
            this.Property(t => t.dataalteracao).HasColumnName("dataalteracao");
            this.Property(t => t.usuarioalteracao).HasColumnName("usuarioalteracao");
        }
    }
}
