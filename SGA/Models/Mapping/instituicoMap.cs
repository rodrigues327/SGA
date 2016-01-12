using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SGA.Models.Mapping
{
    public class instituicoMap : EntityTypeConfiguration<instituico>
    {
        public instituicoMap()
        {
            // Primary Key
            this.HasKey(t => t.cd_instituicao);

            // Properties
            this.Property(t => t.instituicao)
                .HasMaxLength(50);

            this.Property(t => t.razaosocial)
                .HasMaxLength(70);

            this.Property(t => t.cnpj)
                .HasMaxLength(18);

            this.Property(t => t.endereco)
                .HasMaxLength(50);

            this.Property(t => t.bairro)
                .HasMaxLength(50);

            this.Property(t => t.cidade)
                .HasMaxLength(50);

            this.Property(t => t.estado)
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("instituicoes");
            this.Property(t => t.cd_instituicao).HasColumnName("cd_instituicao");
            this.Property(t => t.instituicao).HasColumnName("instituicao");
            this.Property(t => t.razaosocial).HasColumnName("razaosocial");
            this.Property(t => t.cnpj).HasColumnName("cnpj");
            this.Property(t => t.endereco).HasColumnName("endereco");
            this.Property(t => t.bairro).HasColumnName("bairro");
            this.Property(t => t.cidade).HasColumnName("cidade");
            this.Property(t => t.estado).HasColumnName("estado");
        }
    }
}
