using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SGA.Models.Mapping
{
    public class alunoMap : EntityTypeConfiguration<aluno>
    {
        public alunoMap()
        {
            // Primary Key
            this.HasKey(t => t.cd_aluno);

            // Properties
            this.Property(t => t.nome)
                .HasMaxLength(50);

            this.Property(t => t.cpf)
                .HasMaxLength(11);

            this.Property(t => t.identidade)
                .HasMaxLength(15);

            this.Property(t => t.identidadeorgao)
                .HasMaxLength(10);

            this.Property(t => t.sexo)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.estadocivil)
                .IsFixedLength()
                .HasMaxLength(1);

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

            this.Property(t => t.cep)
                .HasMaxLength(8);

            this.Property(t => t.estado)
                .HasMaxLength(2);

            this.Property(t => t.email)
                .HasMaxLength(100);

            this.Property(t => t.telefone)
                .HasMaxLength(10);

            this.Property(t => t.celular)
                .HasMaxLength(10);

            this.Property(t => t.filiacaopai)
                .HasMaxLength(50);

            this.Property(t => t.filiacaomae)
                .HasMaxLength(50);

            this.Property(t => t.naturalidade)
                .HasMaxLength(50);

            this.Property(t => t.nacionalidade)
                .HasMaxLength(50);

            this.Property(t => t.graduacaocurso)
                .HasMaxLength(50);

            this.Property(t => t.graduacaoinstituicao)
                .HasMaxLength(50);

            this.Property(t => t.graduacaoano)
                .HasMaxLength(4);

            this.Property(t => t.empresa)
                .HasMaxLength(50);

            this.Property(t => t.empresatelefone)
                .HasMaxLength(10);

            this.Property(t => t.empresaramal)
                .HasMaxLength(10);

            this.Property(t => t.cargo)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("alunos");
            this.Property(t => t.cd_aluno).HasColumnName("cd_aluno");
            this.Property(t => t.nome).HasColumnName("nome");
            this.Property(t => t.cpf).HasColumnName("cpf");
            this.Property(t => t.identidade).HasColumnName("identidade");
            this.Property(t => t.identidadeorgao).HasColumnName("identidadeorgao");
            this.Property(t => t.datanascimento).HasColumnName("datanascimento");
            this.Property(t => t.sexo).HasColumnName("sexo");
            this.Property(t => t.estadocivil).HasColumnName("estadocivil");
            this.Property(t => t.endereco).HasColumnName("endereco");
            this.Property(t => t.numero).HasColumnName("numero");
            this.Property(t => t.complemento).HasColumnName("complemento");
            this.Property(t => t.bairro).HasColumnName("bairro");
            this.Property(t => t.cidade).HasColumnName("cidade");
            this.Property(t => t.cep).HasColumnName("cep");
            this.Property(t => t.estado).HasColumnName("estado");
            this.Property(t => t.email).HasColumnName("email");
            this.Property(t => t.telefone).HasColumnName("telefone");
            this.Property(t => t.celular).HasColumnName("celular");
            this.Property(t => t.filiacaopai).HasColumnName("filiacaopai");
            this.Property(t => t.filiacaomae).HasColumnName("filiacaomae");
            this.Property(t => t.naturalidade).HasColumnName("naturalidade");
            this.Property(t => t.nacionalidade).HasColumnName("nacionalidade");
            this.Property(t => t.graduacaocurso).HasColumnName("graduacaocurso");
            this.Property(t => t.graduacaoinstituicao).HasColumnName("graduacaoinstituicao");
            this.Property(t => t.graduacaoano).HasColumnName("graduacaoano");
            this.Property(t => t.empresa).HasColumnName("empresa");
            this.Property(t => t.empresatelefone).HasColumnName("empresatelefone");
            this.Property(t => t.empresaramal).HasColumnName("empresaramal");
            this.Property(t => t.cargo).HasColumnName("cargo");
            this.Property(t => t.emancipado).HasColumnName("emancipado");
            this.Property(t => t.datainclusao).HasColumnName("datainclusao");
            this.Property(t => t.usuarioinclusao).HasColumnName("usuarioinclusao");
            this.Property(t => t.dataalteracao).HasColumnName("dataalteracao");
            this.Property(t => t.usuarioalteracao).HasColumnName("usuarioalteracao");
        }
    }
}
