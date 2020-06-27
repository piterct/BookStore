using BookStore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStore.Repositories.Contracts
{
    public interface ICategoryRepository : IDisposable
    {
        List<Categoria> Get();
    }
}