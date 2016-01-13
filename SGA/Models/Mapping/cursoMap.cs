using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SGA.Models.Mapping
{
    public class cursoMap : EntityTypeConfiguration<curso>
    {
        public cursoMap()
        {
            // Primary Key
            this.HasKey(t => t.cd_curso);

            // Properties
            this.Property(t => t.cd_curso)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.curso1)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("cursos");
            this.Property(t => t.cd_curso).HasColumnName("cd_curso");
            this.Property(t => t.curso1).HasColumnName("curso");
            this.Property(t => t.cd_tipocurso).HasColumnName("cd_tipocurso");
            this.Property(t => t.numparcelas).HasColumnName("numparcelas");
            this.Property(t => t.repasse).HasColumnName("repasse");
            this.Property(t => t.mensalidade).HasColumnName("mensalidade");
            this.Property(t => t.datainclusao).HasColumnName("datainclusao");
            this.Property(t => t.usuarioinclusao).HasColumnName("usuarioinclusao");
            this.Property(t => t.dataalteracao).HasColumnName("dataalteracao");
            this.Property(t => t.usuarioalteracao).HasColumnName("usuarioalteracao");

            // Relationships
            this.HasOptional(t => t.tiposcurso)
                .WithMany(t => t.cursos)
                .HasForeignKey(d => d.cd_tipocurso);

        }
    }
}
