using SGA.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SGA.Infrastructure.Data.EntityFramework.EntityMapping
{
    public class TurmaDisciplinaCalendarioMap : EntityTypeConfiguration<TurmaDisciplinaCalendario>
    {
        public TurmaDisciplinaCalendarioMap()
        {
            // Primary Key
            //   this.HasKey(t => new { t.cd_turma, t.cd_disciplina, t.data });

            // Properties
            this.Property(t => t.CdTurma)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.CdDisciplina)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            ToTable("turmasdisciplinascalendario");
            this.Property(t => t.CdTurma).HasColumnName("cd_turma");
            this.Property(t => t.CdDisciplina).HasColumnName("cd_disciplina");
            this.Property(t => t.Data).HasColumnName("data");
            this.Property(t => t.CdProfessor).HasColumnName("cd_professor");
            this.Property(t => t.Datainclusao).HasColumnName("datainclusao");
            this.Property(t => t.Usuarioinclusao).HasColumnName("usuarioinclusao");
            this.Property(t => t.Dataalteracao).HasColumnName("dataalteracao");
            this.Property(t => t.Usuarioalteracao).HasColumnName("usuarioalteracao");

            // Relationships
            this.HasOptional(t => t.Professore)
                .WithMany(t => t.turmasdisciplinascalendarios)
                .HasForeignKey(d => d.CdProfessor);

            //this.HasRequired(t => t.turmasDisciplina)
            //    .WithMany(t => t.Turmasdisciplinascalendarios)
            //    .HasForeignKey(d => new { d.CdTurma, d.CdDisciplina });
        }
    }
}