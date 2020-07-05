using BookStore.Context;
using BookStore.Domain.Entities;
using BookStore.Repositories.Contracts;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace BookStore.Repositories
{
    public class BookRepositoy : IBookRepository
    {
        private readonly BookStoreDataContext _db = new BookStoreDataContext();


        public bool Create(Livro livro)
        {
            try
            {
                _db.Livros.Add(livro);
                _db.SaveChanges();

                return true;
            }

            catch
            {
                return false;
            }
        }

        public Livro Get(int id)
        {
            return _db.Livros.Find(id);
        }

        public List<Livro> Get()
        {
            return _db.Livros.ToList();
        }

        public bool Update(Livro livro)
        {
            try
            {
                _db.Entry<Livro>(livro).State = EntityState.Modified;
                _db.SaveChanges();

                return true;
            }

            catch
            {
                return false;
            }
        }

        public void Dispose()
        {
            _db.Dispose();
        }


    }
}