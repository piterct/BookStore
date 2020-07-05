using BookStore.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace BookStore.InfraStruture.Mapping
{
    public class LivroInfraMap : EntityTypeConfiguration<Livro>
    {
        public LivroInfraMap()
        {
            ToTable("Livro");

            HasKey(x => x.Id);
            Property(x => x.Nome).HasMaxLength(60).IsRequired();
            Property(x => x.ISBN).HasMaxLength(32).IsRequired();
            Property(x => x.DataLancamento).IsRequired();

        }
    }

}
