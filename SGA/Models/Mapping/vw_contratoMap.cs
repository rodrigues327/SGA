using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SGA.Models.Mapping
{
    public class vw_contratoMap : EntityTypeConfiguration<vw_contrato>
    {
        public vw_contratoMap()
        {
            // Primary Key
            this.HasKey(t => t.matricula);

            // Properties
            this.Property(t => t.nome)
                .HasMaxLength(50);

            this.Property(t => t.cpf)
                .HasMaxLength(11);

            this.Property(t => t.cd_alunoexterno)
                .HasMaxLength(11);

            this.Property(t => t.curso)
                .HasMaxLength(255);

            this.Property(t => t.matricula)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

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
            this.ToTable("vw_contrato");
            this.Property(t => t.nome).HasColumnName("nome");
            this.Property(t => t.cpf).HasColumnName("cpf");
            this.Property(t => t.cd_alunoexterno).HasColumnName("cd_alunoexterno");
            this.Property(t => t.curso).HasColumnName("curso");
            this.Property(t => t.datainicial).HasColumnName("datainicial");
            this.Property(t => t.datafinal).HasColumnName("datafinal");
            this.Property(t => t.total).HasColumnName("total");
            this.Property(t => t.numparcelas).HasColumnName("numparcelas");
            this.Property(t => t.matricula).HasColumnName("matricula");
            this.Property(t => t.valor).HasColumnName("valor");
            this.Property(t => t.dia).HasColumnName("dia");
            this.Property(t => t.vencimento).HasColumnName("vencimento");
            this.Property(t => t.desconto).HasColumnName("desconto");
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
