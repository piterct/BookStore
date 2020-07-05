using BookStore.Domain.Entities;
using System;
using System.Collections.Generic;

namespace BookStore.Repositories.Contracts
{
    public interface ICategoryRepository : IDisposable
    {
        List<Categoria> Get();
    }
}