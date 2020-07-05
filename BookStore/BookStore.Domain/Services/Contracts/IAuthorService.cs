using BookStore.Domain.Entities;
using System.Collections.Generic;

namespace BookStore.Domain.Services.Contracts
{
    public interface IAuthorService
    {
        List<Autor> Get();
    }
}
