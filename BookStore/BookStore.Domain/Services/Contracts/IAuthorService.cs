using BookStore.Domain.Entities;
using System.Collections.Generic;

namespace BookStore.Domain.Services.Contracts
{
    public interface IAuthorService
    {
        List<Autor> Get();
        Autor Get(int id);
        List<Autor> GetByName(string name);
        bool Create(Autor author);
        bool Update(Autor author);
        void Delete(int author);
    }
}
