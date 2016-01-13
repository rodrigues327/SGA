using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SGA.Models.Mapping
{
    public class vw_reldocsMap : EntityTypeConfiguration<vw_reldocs>
    {
        public vw_reldocsMap()
        {
            // Primary Key
            this.HasKey(t => t.status);

            // Properties
            this.Property(t => t.cd_turma)
                .HasMaxLength(8);

            this.Property(t => t.turma)
                .HasMaxLength(50);

            this.Property(t => t.nome)
                .HasMaxLength(50);

            this.Property(t => t.documento)
                .HasMaxLength(50);

            this.Property(t => t.status)
                .IsRequired()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("vw_reldocs");
            this.Property(t => t.cd_turma).HasColumnName("cd_turma");
            this.Property(t => t.turma).HasColumnName("turma");
            this.Property(t => t.nome).HasColumnName("nome");
            this.Property(t => t.documento).HasColumnName("documento");
            this.Property(t => t.status).HasColumnName("status");
            this.Property(t => t.ordem).HasColumnName("ordem");
            this.Property(t => t.cd_tipocurso).HasColumnName("cd_tipocurso");
        }
    }
}
