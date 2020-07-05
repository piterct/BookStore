using BookStore.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace BookStore.InfraStruture.Mapping
{
    public class AutorInfraMap : EntityTypeConfiguration<Autor>
    {
        public AutorInfraMap()
        {
            ToTable("Autor");

            HasKey(x => x.Id);
            Property(x => x.Nome).HasMaxLength(60).IsRequired();

            HasMany(x => x.Livros)
                .WithMany(x => x.Autores)
                .Map(x => x.ToTable("LivroAutor"));
        }
    }

}
