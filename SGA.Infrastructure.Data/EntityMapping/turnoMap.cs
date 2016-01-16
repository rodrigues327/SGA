using SGA.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace SGA.Infrastructure.Data.EntityMapping
{
    public class TurnoMap : EntityTypeConfiguration<Turno>
    {
        public TurnoMap()
        {
            // Primary Key
            this.HasKey(t => t.CdTurno);

            // Properties
            this.Property(t => t.Turno1)
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("turnos");
            this.Property(t => t.CdTurno).HasColumnName("cd_turno");
            this.Property(t => t.Turno1).HasColumnName("turno");
        }
    }
}