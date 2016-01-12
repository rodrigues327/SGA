using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SGA.Models.Mapping
{
    public class gruposMap : EntityTypeConfiguration<grupos>
    {
        public gruposMap()
        {
            // Primary Key
            this.HasKey(t => t.cd_grupo);

            // Properties
            this.Property(t => t.grupo)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("grupos");
            this.Property(t => t.cd_grupo).HasColumnName("cd_grupo");
            this.Property(t => t.grupo).HasColumnName("grupo");
        }
    }
}
