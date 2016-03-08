using SGA.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace SGA.Infrastructure.Data.EntityFramework.EntityMapping
{
    public class P001Map : EntityTypeConfiguration<P001>
    {
        public P001Map()
        {
            // Primary Key
            HasKey(t => t.cd_interface);

            // Properties
            Property(t => t.nome)
                .HasMaxLength(50);

            Property(t => t.caminho)
                .HasMaxLength(255);

            Property(t => t.tipo)
                .HasMaxLength(1);

            // Table & Column Mappings
            ToTable("p001");
            Property(t => t.cd_interface).HasColumnName("cd_interface");
            Property(t => t.nome).HasColumnName("nome");
            Property(t => t.caminho).HasColumnName("caminho");
            Property(t => t.tipo).HasColumnName("tipo");
        }
    }
}