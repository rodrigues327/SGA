using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SGA.Models.Mapping
{
    public class p001Map : EntityTypeConfiguration<p001>
    {
        public p001Map()
        {
            // Primary Key
            this.HasKey(t => t.cd_interface);

            // Properties
            this.Property(t => t.nome)
                .HasMaxLength(50);

            this.Property(t => t.caminho)
                .HasMaxLength(255);

            this.Property(t => t.tipo)
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("p001");
            this.Property(t => t.cd_interface).HasColumnName("cd_interface");
            this.Property(t => t.nome).HasColumnName("nome");
            this.Property(t => t.caminho).HasColumnName("caminho");
            this.Property(t => t.tipo).HasColumnName("tipo");
        }
    }
}
