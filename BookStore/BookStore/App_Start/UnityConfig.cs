using BookStore.Context;
using BookStore.Repositories;
using BookStore.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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
            container.RegisterType<BookStoreDataContext, BookStoreDataContext>();
            container.RegisterType<IAuthorRepository, AuthorRepository>();
            container.RegisterType<ICategoryRepository, CategoryRepository>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}