using SGA.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace SGA.Infrastructure.Data.EntityMapping
{
    public class InstituicaoMap : EntityTypeConfiguration<Instituicao>
    {
        public InstituicaoMap()
        {
            // Primary Key
            HasKey(t => t.cd_instituicao);

            // Properties
            Property(t => t.instituicao)
                .HasMaxLength(50);

            Property(t => t.razaosocial)
                .HasMaxLength(70);

            Property(t => t.cnpj)
                .HasMaxLength(18);

            Property(t => t.endereco)
                .HasMaxLength(50);

            Property(t => t.bairro)
                .HasMaxLength(50);

            Property(t => t.cidade)
                .HasMaxLength(50);

            Property(t => t.estado)
                .HasMaxLength(2);

            // Table & Column Mappings
            ToTable("instituicoes");
            Property(t => t.cd_instituicao).HasColumnName("cd_instituicao");
            Property(t => t.instituicao).HasColumnName("instituicao");
            Property(t => t.razaosocial).HasColumnName("razaosocial");
            Property(t => t.cnpj).HasColumnName("cnpj");
            Property(t => t.endereco).HasColumnName("endereco");
            Property(t => t.bairro).HasColumnName("bairro");
            Property(t => t.cidade).HasColumnName("cidade");
            Property(t => t.estado).HasColumnName("estado");
        }
    }
}