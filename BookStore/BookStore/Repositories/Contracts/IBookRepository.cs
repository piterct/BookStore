using BookStore.Domain.Entities;
using System;
using System.Collections.Generic;

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