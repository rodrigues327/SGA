using SGA.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace SGA.Infrastructure.Data.EntityMapping
{
    public class AlunoFinanceiroMap : EntityTypeConfiguration<AlunoFinanceiro>
    {
        public AlunoFinanceiroMap()
        {
            // Table & Column Mappings
            ToTable("alunosfinanceiro");
            // Primary Key
            HasKey(t => t.Guid);
            this.Property(t => t.cd_aluno).HasColumnName("cd_aluno");
            this.Property(t => t.cd_turma).HasColumnName("cd_turma");
            this.Property(t => t.cd_mensalidade).HasColumnName("cd_mensalidade");
            this.Property(t => t.cd_formapagamento).HasColumnName("cd_formapagamento");
            this.Property(t => t.numdocumento).HasColumnName("numdocumento");
            this.Property(t => t.datavencimento).HasColumnName("datavencimento");
            this.Property(t => t.valor).HasColumnName("valor");
            this.Property(t => t.desconto).HasColumnName("desconto");
            this.Property(t => t.bolsa).HasColumnName("bolsa");
            this.Property(t => t.datapagamento).HasColumnName("datapagamento");
            this.Property(t => t.valorpago).HasColumnName("valorpago");
            this.Property(t => t.conta).HasColumnName("conta").HasMaxLength(20); ;
            this.Property(t => t.datainclusao).HasColumnName("datainclusao");
            this.Property(t => t.usuarioinclusao).HasColumnName("usuarioinclusao");
            this.Property(t => t.dataalteracao).HasColumnName("dataalteracao");
            this.Property(t => t.usuarioalteracao).HasColumnName("usuarioalteracao");

            // Relationships
            this.HasRequired(t => t.alunosturma)
                .WithMany(t => t.alunosfinanceiroes)
                .HasForeignKey(d => new { d.cd_aluno, d.cd_turma });
            this.HasRequired(t => t.formaspagamento)
                .WithMany(t => t.alunosfinanceiroes)
                .HasForeignKey(d => d.cd_formapagamento);
        }
    }
}