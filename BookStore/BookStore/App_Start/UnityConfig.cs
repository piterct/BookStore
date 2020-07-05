﻿using BookStore.Context;
using BookStore.Domain.Services.Contracts;
using BookStore.Repositories;
using BookStore.Repositories.Contracts;
using BooStore.Service.Services;
using System.Web.Mvc;
using Unity;
using Unity.AspNet.Mvc;

namespace BookStore.App_Start
{
    public class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();


            // register all your components with the container here
            // it is NOT necessary to register your controllers
            #region Configurations
            container.RegisterType<BookStoreDataContext, BookStoreDataContext>();
            #endregion

            #region Services
            container.RegisterType<IAuthorService, AuthorService>();

            #endregion

            #region Repositories
            container.RegisterType<IAuthorRepository, AuthorRepository>();
            container.RegisterType<ICategoryRepository, CategoryRepository>();
            container.RegisterType<IBookRepository, BookRepositoy>();
            #endregion

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}