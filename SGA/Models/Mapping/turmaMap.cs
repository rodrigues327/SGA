using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SGA.Models.Mapping
{
    public class turmaMap : EntityTypeConfiguration<turma>
    {
        public turmaMap()
        {
            // Primary Key
            this.HasKey(t => t.cd_turma);

            // Properties
            this.Property(t => t.cd_turma)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.turma1)
                .HasMaxLength(50);

            this.Property(t => t.cd_local)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.cd_curso)
                .IsRequired()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("turmas");
            this.Property(t => t.cd_turma).HasColumnName("cd_turma");
            this.Property(t => t.turma1).HasColumnName("turma");
            this.Property(t => t.cd_instituicao).HasColumnName("cd_instituicao");
            this.Property(t => t.cd_local).HasColumnName("cd_local");
            this.Property(t => t.cd_curso).HasColumnName("cd_curso");
            this.Property(t => t.cd_formapagamento).HasColumnName("cd_formapagamento");
            this.Property(t => t.numparcelas).HasColumnName("numparcelas");
            this.Property(t => t.mensalidade).HasColumnName("mensalidade");
            this.Property(t => t.desconto).HasColumnName("desconto");
            this.Property(t => t.datainicial).HasColumnName("datainicial");
            this.Property(t => t.datafinal).HasColumnName("datafinal");
            this.Property(t => t.cd_turno).HasColumnName("cd_turno");
            this.Property(t => t.cd_parceiro).HasColumnName("cd_parceiro");
            this.Property(t => t.parceiroperc).HasColumnName("parceiroperc");
            this.Property(t => t.datainclusao).HasColumnName("datainclusao");
            this.Property(t => t.usuarioinclusao).HasColumnName("usuarioinclusao");
            this.Property(t => t.dataalteracao).HasColumnName("dataalteracao");
            this.Property(t => t.usuarioalteracao).HasColumnName("usuarioalteracao");

            // Relationships
            this.HasRequired(t => t.curso)
                .WithMany(t => t.turmas)
                .HasForeignKey(d => d.cd_curso);
            this.HasRequired(t => t.formaspagamento)
                .WithMany(t => t.turmas)
                .HasForeignKey(d => d.cd_formapagamento);
            this.HasRequired(t => t.locai)
                .WithMany(t => t.turmas)
                .HasForeignKey(d => d.cd_local);
            this.HasOptional(t => t.parceiro)
                .WithMany(t => t.turmas)
                .HasForeignKey(d => d.cd_parceiro);
            this.HasOptional(t => t.turno)
                .WithMany(t => t.turmas)
                .HasForeignKey(d => d.cd_turno);

        }
    }
}
