using SGA.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace SGA.Infrastructure.Data.EntityMapping
{
    public class TurmaMap : EntityTypeConfiguration<Turma>
    {
        public TurmaMap()
        {
            // Primary Key
            this.HasKey(t => t.CdTurma);

            // Properties
            this.Property(t => t.CdTurma)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.Turma1)
                .HasMaxLength(50);

            this.Property(t => t.CdLocal)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.CdCurso)
                .IsRequired()
                .HasMaxLength(2);

            // Table & Column Mappings
            ToTable("turmas");
            this.Property(t => t.CdTurma).HasColumnName("cd_turma");
            this.Property(t => t.Turma1).HasColumnName("turma");
            this.Property(t => t.CdInstituicao).HasColumnName("cd_instituicao");
            this.Property(t => t.CdLocal).HasColumnName("cd_local");
            this.Property(t => t.CdCurso).HasColumnName("cd_curso");
            this.Property(t => t.CdFormapagamento).HasColumnName("cd_formapagamento");
            this.Property(t => t.Numparcelas).HasColumnName("numparcelas");
            this.Property(t => t.Mensalidade).HasColumnName("mensalidade");
            this.Property(t => t.Desconto).HasColumnName("desconto");
            this.Property(t => t.Datainicial).HasColumnName("datainicial");
            this.Property(t => t.Datafinal).HasColumnName("datafinal");
            this.Property(t => t.CdTurno).HasColumnName("cd_turno");
            this.Property(t => t.CdParceiro).HasColumnName("cd_parceiro");
            this.Property(t => t.Parceiroperc).HasColumnName("parceiroperc");
            this.Property(t => t.Datainclusao).HasColumnName("datainclusao");
            this.Property(t => t.Usuarioinclusao).HasColumnName("usuarioinclusao");
            this.Property(t => t.Dataalteracao).HasColumnName("dataalteracao");
            this.Property(t => t.Usuarioalteracao).HasColumnName("usuarioalteracao");

            // Relationships
            this.HasRequired(t => t.Curso)
                .WithMany(t => t.turmas)
                .HasForeignKey(d => d.CdCurso);
            this.HasRequired(t => t.Formaspagamento)
                .WithMany(t => t.turmas)
                .HasForeignKey(d => d.CdFormapagamento);
            this.HasRequired(t => t.Locai)
                .WithMany(t => t.turmas)
                .HasForeignKey(d => d.CdLocal);
            this.HasOptional(t => t.Parceiro)
                .WithMany(t => t.turmas)
                .HasForeignKey(d => d.CdParceiro);
            this.HasOptional(t => t.Turno)
                .WithMany(t => t.Turmas)
                .HasForeignKey(d => d.CdTurno);
        }
    }
}