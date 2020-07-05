using BookStore.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace BookStore.InfraStruture.Mapping
{
    public class CategoriaInfraMap : EntityTypeConfiguration<Categoria>
    {
        public CategoriaInfraMap()
        {
            ToTable("Categoria");

            HasKey(x => x.Id);
            Property(x => x.Nome).HasMaxLength(30).IsRequired();

            HasMany(x => x.Livros)
                .WithRequired(x => x.Categoria);
        }

    }
}
