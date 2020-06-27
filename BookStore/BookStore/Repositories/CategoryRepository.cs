using BookStore.Context;
using BookStore.Domain;
using BookStore.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStore.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private BookStoreDataContext _db = new BookStoreDataContext();
        

        public List<Categoria> Get()
        {
            return _db.Categorias.ToList();
        }

        public void Dispose()
        {
            _db.Dispose();
        }
    }
}