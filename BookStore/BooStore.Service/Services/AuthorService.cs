
using BookStore.Domain.Entities;
using BookStore.Domain.Repositories.Contracts;
using BookStore.Domain.Services.Contracts;
using System.Collections.Generic;

namespace BooStore.Service.Services
{
    public class AuthorService : IAuthorService
    {
        private readonly IAuthorInfraRepository _repositoryInfra;

        public AuthorService(IAuthorInfraRepository repositoryInfra)
        {
            _repositoryInfra = repositoryInfra;
        }

        public List<Autor> Get()
        {
            return _repositoryInfra.Get();
        }

        public bool Create(Autor author)
        {
            return _repositoryInfra.Create(author);
        }

        public Autor Get(int id)
        {
            return _repositoryInfra.Get(id);
        }

        public bool Update(Autor author)
        {
            return _repositoryInfra.Update(author);
        }

        public void Delete(int author)
        {
            _repositoryInfra.Delete(author);
        }

        public List<Autor> GetByName(string name)
        {
            return _repositoryInfra.GetByName(name);
        }


        #region Methods Private

        #endregion
    }
}
