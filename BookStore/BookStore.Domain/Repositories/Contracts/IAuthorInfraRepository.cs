using BookStore.Domain.Entities;
using System.Collections.Generic;

namespace BookStore.Domain.Repositories.Contracts
{
    public interface IAuthorInfraRepository
    {
        List<Autor> Get();
        Autor Get(int id);
        List<Autor> GetByName(string name);
        bool Create(Autor autor);
        bool Update(Autor autor);
        void Delete(int autor);
    }
}
