namespace SGA.Infrastructure.Data.EntityMapping
{
    //public class GruposmenuMap : EntityTypeConfiguration<gruposmenu>
    //{
    //    public GruposmenuMap()
    //    {
    //        // Primary Key
    //        this.HasKey(t => new { t.cd_grupo, t.cd_menu });

    //        // Properties
    //        this.Property(t => t.cd_grupo)
    //            .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

    //        this.Property(t => t.cd_menu)
    //            .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

    //        // Table & Column Mappings
    //        ToTable("gruposmenus");
    //        this.Property(t => t.cd_grupo).HasColumnName("cd_grupo");
    //        this.Property(t => t.cd_menu).HasColumnName("cd_menu");
    //        this.Property(t => t.criar).HasColumnName("criar");
    //        this.Property(t => t.exibir).HasColumnName("exibir");
    //        this.Property(t => t.alterar).HasColumnName("alterar");
    //        this.Property(t => t.excluir).HasColumnName("excluir");
    //        this.Property(t => t.baixar).HasColumnName("baixar");

    //        // Relationships
    //        this.HasRequired(t => t.grupos)
    //            .WithMany(t => t.gruposmenus)
    //            .HasForeignKey(d => d.cd_grupo);
    //        this.HasRequired(t => t.menu)
    //            .WithMany(t => t.gruposmenus)
    //            .HasForeignKey(d => d.cd_menu);

    //    }
    //}
}