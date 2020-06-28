using BookStore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStore.Repositories.Contracts
{
    public interface IBookRepository : IDisposable
    {
        bool Create(Livro livro);
        bool Update(Livro livro);
        List<Livro> Get();
        Livro Get(int id);
    }
}