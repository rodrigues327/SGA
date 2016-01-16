using SGA.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace SGA.Infrastructure.Data.EntityMapping
{
    public class ProfessorMap : EntityTypeConfiguration<Professor>
    {
        public ProfessorMap()
        {
            // Primary Key
            this.HasKey(t => t.cd_professor);

            // Properties
            this.Property(t => t.nome)
                .HasMaxLength(50);

            this.Property(t => t.endereco)
                .HasMaxLength(100);

            this.Property(t => t.numero)
                .HasMaxLength(20);

            this.Property(t => t.complemento)
                .HasMaxLength(20);

            this.Property(t => t.bairro)
                .HasMaxLength(50);

            this.Property(t => t.cidade)
                .HasMaxLength(50);

            this.Property(t => t.estado)
                .HasMaxLength(2);

            this.Property(t => t.cep)
                .HasMaxLength(8);

            this.Property(t => t.telefone1)
                .HasMaxLength(10);

            this.Property(t => t.telefone2)
                .HasMaxLength(10);

            this.Property(t => t.telefone3)
                .HasMaxLength(10);

            this.Property(t => t.email1)
                .HasMaxLength(100);

            this.Property(t => t.email2)
                .HasMaxLength(100);

            this.Property(t => t.email3)
                .HasMaxLength(100);

            this.Property(t => t.area)
                .HasMaxLength(50);

            this.Property(t => t.instituicao)
                .HasMaxLength(50);

            this.Property(t => t.banco)
                .HasMaxLength(10);

            this.Property(t => t.agencia)
                .HasMaxLength(10);

            this.Property(t => t.conta)
                .HasMaxLength(10);

            this.Property(t => t.favorecido)
                .HasMaxLength(50);

            this.Property(t => t.pis)
                .HasMaxLength(15);

            this.Property(t => t.cpf)
                .HasMaxLength(11);

            // Table & Column Mappings
            ToTable("professores");
            this.Property(t => t.cd_professor).HasColumnName("cd_professor");
            this.Property(t => t.nome).HasColumnName("nome");
            this.Property(t => t.endereco).HasColumnName("endereco");
            this.Property(t => t.numero).HasColumnName("numero");
            this.Property(t => t.complemento).HasColumnName("complemento");
            this.Property(t => t.bairro).HasColumnName("bairro");
            this.Property(t => t.cidade).HasColumnName("cidade");
            this.Property(t => t.estado).HasColumnName("estado");
            this.Property(t => t.cep).HasColumnName("cep");
            this.Property(t => t.telefone1).HasColumnName("telefone1");
            this.Property(t => t.telefone2).HasColumnName("telefone2");
            this.Property(t => t.telefone3).HasColumnName("telefone3");
            this.Property(t => t.email1).HasColumnName("email1");
            this.Property(t => t.email2).HasColumnName("email2");
            this.Property(t => t.email3).HasColumnName("email3");
            this.Property(t => t.titulacao).HasColumnName("titulacao");
            this.Property(t => t.area).HasColumnName("area");
            this.Property(t => t.instituicao).HasColumnName("instituicao");
            this.Property(t => t.ano).HasColumnName("ano");
            this.Property(t => t.banco).HasColumnName("banco");
            this.Property(t => t.agencia).HasColumnName("agencia");
            this.Property(t => t.conta).HasColumnName("conta");
            this.Property(t => t.favorecido).HasColumnName("favorecido");
            this.Property(t => t.datanascimento).HasColumnName("datanascimento");
            this.Property(t => t.pis).HasColumnName("pis");
            this.Property(t => t.cpf).HasColumnName("cpf");
            this.Property(t => t.datainclusao).HasColumnName("datainclusao");
            this.Property(t => t.usuarioinclusao).HasColumnName("usuarioinclusao");
            this.Property(t => t.dataalteracao).HasColumnName("dataalteracao");
            this.Property(t => t.usuarioalteracao).HasColumnName("usuarioalteracao");
        }
    }
}