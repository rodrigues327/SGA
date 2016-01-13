using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SGA.Models.Mapping
{
    public class vw_relcalendarioMap : EntityTypeConfiguration<vw_relcalendario>
    {
        public vw_relcalendarioMap()
        {
            // Primary Key
            this.HasKey(t => new { t.cd_turma, t.data });

            // Properties
            this.Property(t => t.cd_turma)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.turma)
                .HasMaxLength(50);

            this.Property(t => t.disciplina)
                .HasMaxLength(100);

            this.Property(t => t.nome)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("vw_relcalendario");
            this.Property(t => t.cd_turma).HasColumnName("cd_turma");
            this.Property(t => t.turma).HasColumnName("turma");
            this.Property(t => t.disciplina).HasColumnName("disciplina");
            this.Property(t => t.nome).HasColumnName("nome");
            this.Property(t => t.data).HasColumnName("data");
        }
    }
}
