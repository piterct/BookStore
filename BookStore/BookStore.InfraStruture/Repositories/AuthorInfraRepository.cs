using BookStore.Domain.Entities;
using BookStore.Domain.Repositories.Contracts;
using BookStore.InfraStruture.Context;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace BookStore.InfraStruture.Repositories
{
    public class AuthorInfraRepository : IAuthorInfraRepository
    {
        private BookStoreInfraDataContext _db = new BookStoreInfraDataContext();
        public bool Create(Autor autor)
        {
            try
            {
                _db.Autores.Add(autor);
                _db.SaveChanges();

                return true;
            }

            catch
            {
                return false;
            }
        }

        public bool Update(Autor autor)
        {
            try
            {
                _db.Entry<Autor>(autor).State = EntityState.Modified;
                _db.SaveChanges();

                return true;
            }

            catch
            {
                return false;
            }
        }


        public void Delete(int id)
        {
            var autor = _db.Autores.Find(id);
            _db.Autores.Remove(autor);
            _db.SaveChanges();
        }

        public List<Autor> Get()
        {
            return _db.Autores.ToList();
        }

        public Autor Get(int id)
        {
            return _db.Autores.Find(id);
        }

        public List<Autor> GetByName(string name)
        {
            return _db.Autores.Where(x => x.Nome.Contains(name)).ToList();
        }


        public void Dispose()
        {
            _db.Dispose();
        }
    }
}
