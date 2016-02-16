namespace SGA.Infrastructure.Data.EntityFramework.EntityMapping
{
    //public class TurmaDisciplinaMap : EntityTypeConfiguration<TurmaDisciplina>
    //{
    //    public TurmaDisciplinaMap()
    //    {
    //        // Properties
    //        this.Property(t => t.CdTurma)
    //            .IsRequired()
    //            .HasMaxLength(8);

    //        this.Property(t => t.CdDisciplina)
    //            .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

    //        // Table & Column Mappings
    //        ToTable("turmasdisciplinas");
    //        HasKey(t => t.Guid);
    //        this.Property(t => t.CdTurma).HasColumnName("cd_turma");
    //        this.Property(t => t.CdDisciplina).HasColumnName("cd_disciplina");
    //        this.Property(t => t.Datainclusao).HasColumnName("datainclusao");
    //        this.Property(t => t.Usuarioinclusao).HasColumnName("usuarioinclusao");
    //        this.Property(t => t.Dataalteracao).HasColumnName("dataalteracao");
    //        this.Property(t => t.Usuarioalteracao).HasColumnName("usuarioalteracao");

    //        // Relationships
    //        this.HasRequired(t => t.Disciplina)
    //            .WithMany(t => t.turmasdisciplinas)
    //            .HasForeignKey(d => d.CdDisciplina);
    //    }
    //}
}