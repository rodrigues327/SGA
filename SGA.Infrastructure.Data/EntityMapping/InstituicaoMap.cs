using SGA.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace SGA.Infrastructure.Data.EntityMapping
{
    public class InstituicaoMap : EntityTypeConfiguration<Instituicao>
    {
        public InstituicaoMap()
        {
            // Table & Column Mappings
            ToTable("instituicoes");

            HasKey(t => t.Guid);
            Property(t => t.CdInstituicao).HasColumnName("cd_instituicao");
            Property(t => t.Nome).HasColumnName("instituicao").HasMaxLength(50);
            Property(t => t.Razaosocial).HasColumnName("razaosocial").HasMaxLength(70); ;
            Property(t => t.Cnpj).HasColumnName("cnpj").HasMaxLength(18); ;
            Property(t => t.Endereco).HasColumnName("endereco").HasMaxLength(50); ;
            Property(t => t.Bairro).HasColumnName("bairro").HasMaxLength(50); ;
            Property(t => t.Cidade).HasColumnName("cidade").HasMaxLength(50); ;
            Property(t => t.Estado).HasColumnName("estado").HasMaxLength(2); ;
        }
    }
}