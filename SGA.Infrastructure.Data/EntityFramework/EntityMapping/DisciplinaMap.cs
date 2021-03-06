using SGA.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace SGA.Infrastructure.Data.EntityFramework.EntityMapping
{
    public class DisciplinaMap : EntityTypeConfiguration<Disciplina>
    {
        public DisciplinaMap()
        {
            // Primary Key
            this.HasKey(t => t.cd_disciplina);

            // Properties
            this.Property(t => t.disciplina1)
                .HasMaxLength(100);

            // Table & Column Mappings
            ToTable("disciplinas");
            this.Property(t => t.cd_disciplina).HasColumnName("cd_disciplina");
            this.Property(t => t.disciplina1).HasColumnName("disciplina");
            this.Property(t => t.cargahoraria).HasColumnName("cargahoraria");
            this.Property(t => t.cd_professor).HasColumnName("cd_professor");
            this.Property(t => t.datainclusao).HasColumnName("datainclusao");
            this.Property(t => t.usuarioinclusao).HasColumnName("usuarioinclusao");
            this.Property(t => t.dataalteracao).HasColumnName("dataalteracao");
            this.Property(t => t.usuarioalteracao).HasColumnName("usuarioalteracao");

            // Relationships
            this.HasOptional(t => t.professore)
                .WithMany(t => t.disciplinas)
                .HasForeignKey(d => d.cd_professor);
        }
    }
}