using BookStore.Domain.Entities;
using BookStore.InfraStruture.Mapping;
using System.Data.Entity;

namespace BookStore.InfraStruture.Context
{
    public class BookStoreInfraDataContext : DbContext
    {
        public BookStoreInfraDataContext()
        : base("BookStoreConnectionString")
        {


        }

        public DbSet<Autor> Autores { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Livro> Livros { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AutorInfraMap());
            modelBuilder.Configurations.Add(new CategoriaInfraMap());
            modelBuilder.Configurations.Add(new LivroInfraMap());
        }
    }
}
