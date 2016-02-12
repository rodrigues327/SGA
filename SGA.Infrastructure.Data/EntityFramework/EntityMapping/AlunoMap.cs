using SGA.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace SGA.Infrastructure.Data.EntityFramework.EntityMapping
{
    public class AlunoMap : EntityTypeConfiguration<Aluno>
    {
        public AlunoMap()
        {
            // Table & Column Mappings
            ToTable("alunos");

            // Primary Key
            HasKey(t => t.CdAluno);

            // Properties
            Property(t => t.Nome)
                .HasMaxLength(50);

            Property(t => t.Cpf)
                .HasMaxLength(11);

            Property(t => t.Identidade)
                .HasMaxLength(15);

            Property(t => t.Identidadeorgao)
                .HasMaxLength(10);

            Property(t => t.Sexo)
                .IsFixedLength()
                .HasMaxLength(1);

            Property(t => t.Estadocivil)
                .IsFixedLength()
                .HasMaxLength(1);

            Property(t => t.Endereco)
                .HasMaxLength(100);

            Property(t => t.Numero)
                .HasMaxLength(20);

            Property(t => t.Complemento)
                .HasMaxLength(20);

            Property(t => t.Bairro)
                .HasMaxLength(50);

            Property(t => t.Cidade)
                .HasMaxLength(50);

            Property(t => t.Cep)
                .HasMaxLength(8);

            Property(t => t.Estado)
                .HasMaxLength(2);

            Property(t => t.Email)
                .HasMaxLength(100);

            Property(t => t.Telefone)
                .HasMaxLength(10);

            Property(t => t.Celular)
                .HasMaxLength(10);

            Property(t => t.Filiacaopai)
                .HasMaxLength(50);

            Property(t => t.Filiacaomae)
                .HasMaxLength(50);

            Property(t => t.Naturalidade)
                .HasMaxLength(50);

            Property(t => t.Nacionalidade)
                .HasMaxLength(50);

            Property(t => t.Graduacaocurso)
                .HasMaxLength(50);

            Property(t => t.Graduacaoinstituicao)
                .HasMaxLength(50);

            Property(t => t.Graduacaoano)
                .HasMaxLength(4);

            Property(t => t.Empresa)
                .HasMaxLength(50);

            Property(t => t.Empresatelefone)
                .HasMaxLength(10);

            Property(t => t.Empresaramal)
                .HasMaxLength(10);

            Property(t => t.Cargo)
                .HasMaxLength(50);
        }
    }
}