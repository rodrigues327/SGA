using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SGA.Models.Mapping
{
    public class vw_relcarneMap : EntityTypeConfiguration<vw_relcarne>
    {
        public vw_relcarneMap()
        {
            // Primary Key
            this.HasKey(t => new { t.cd_curso, t.cd_mensalidade });

            // Properties
            this.Property(t => t.cd_alunoexterno)
                .HasMaxLength(11);

            this.Property(t => t.nome)
                .HasMaxLength(50);

            this.Property(t => t.cpf)
                .HasMaxLength(11);

            this.Property(t => t.cd_curso)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.curso)
                .HasMaxLength(255);

            this.Property(t => t.cd_mensalidade)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("vw_relcarne");
            this.Property(t => t.cd_alunoexterno).HasColumnName("cd_alunoexterno");
            this.Property(t => t.nome).HasColumnName("nome");
            this.Property(t => t.cpf).HasColumnName("cpf");
            this.Property(t => t.cd_curso).HasColumnName("cd_curso");
            this.Property(t => t.curso).HasColumnName("curso");
            this.Property(t => t.cd_mensalidade).HasColumnName("cd_mensalidade");
            this.Property(t => t.valor).HasColumnName("valor");
            this.Property(t => t.datavencimento).HasColumnName("datavencimento");
        }
    }
}
