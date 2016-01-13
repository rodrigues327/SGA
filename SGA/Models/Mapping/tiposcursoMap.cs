using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SGA.Models.Mapping
{
    public class tiposcursoMap : EntityTypeConfiguration<tiposcurso>
    {
        public tiposcursoMap()
        {
            // Primary Key
            this.HasKey(t => t.cd_tipocurso);

            // Properties
            this.Property(t => t.cd_tipocurso)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.tipocurso)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("tiposcursos");
            this.Property(t => t.cd_tipocurso).HasColumnName("cd_tipocurso");
            this.Property(t => t.tipocurso).HasColumnName("tipocurso");
        }
    }
}
