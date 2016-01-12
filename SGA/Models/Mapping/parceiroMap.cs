using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SGA.Models.Mapping
{
    public class parceiroMap : EntityTypeConfiguration<parceiro>
    {
        public parceiroMap()
        {
            // Primary Key
            this.HasKey(t => t.cd_parceiro);

            // Properties
            this.Property(t => t.parceiro1)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("parceiros");
            this.Property(t => t.cd_parceiro).HasColumnName("cd_parceiro");
            this.Property(t => t.parceiro1).HasColumnName("parceiro");
            this.Property(t => t.datainclusao).HasColumnName("datainclusao");
            this.Property(t => t.usuarioinclusao).HasColumnName("usuarioinclusao");
            this.Property(t => t.dataalteracao).HasColumnName("dataalteracao");
            this.Property(t => t.usuarioalteracao).HasColumnName("usuarioalteracao");
        }
    }
}
