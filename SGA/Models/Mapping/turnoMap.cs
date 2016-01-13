using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SGA.Models.Mapping
{
    public class turnoMap : EntityTypeConfiguration<turno>
    {
        public turnoMap()
        {
            // Primary Key
            this.HasKey(t => t.cd_turno);

            // Properties
            this.Property(t => t.turno1)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("turnos");
            this.Property(t => t.cd_turno).HasColumnName("cd_turno");
            this.Property(t => t.turno1).HasColumnName("turno");
        }
    }
}
