﻿using BookStore.Domain;
using BookStore.Repositories.Contracts;
using BookStore.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookStore.Controllers
{
    [RoutePrefix("livros")]
    public class LivroController : Controller
    {
        private IBookRepository _repository;
        private ICategoryRepository _categoryRepository;


        public LivroController(IBookRepository repository, ICategoryRepository categoryRepository)
        {
            _repository = repository;
            _categoryRepository = categoryRepository;
        }

        [Route("listar")]
        public ActionResult Index()
        {
            var livros = _repository.Get();
            return View(livros);
        }

        [Route("criar")]
        public ActionResult Create()
        {
            var categorias = _categoryRepository.Get();
            var model = new EditorBookViewModel
            {
                Nome = "",
                ISBN = "",
                CategoriaId = 0,
                CategoriaOption = new SelectList(categorias, "Id", "Nome")
            };

            return View(model);
        }

        [Route("criar")]
        [HttpPost]
        public ActionResult Create(EditorBookViewModel model)
        {
            var livro = new Livro();
            livro.Nome = model.Nome;
            livro.ISBN = model.ISBN;
            livro.DataLancamento = model.DataLancamento;
            livro.CategoriaId = model.CategoriaId;
            _repository.Create(livro);

            return RedirectToAction("Index");
        }



        [Route("editar")]
        public ActionResult Edit(int id)
        {
            var categorias = _categoryRepository.Get();
            var livro = _repository.Get(id);
            var model = new EditorBookViewModel
            {
                Nome = livro.Nome,
                ISBN = livro.ISBN,
                CategoriaId = livro.CategoriaId,
                CategoriaOption = new SelectList(categorias, "Id", "Nome")
            };

            return View(model);
        }

        [Route("editar")]
        [HttpPost]
        public ActionResult Edit(EditorBookViewModel model)
        {
            var editBook = new Livro();
            editBook.Id = model.Id;
            editBook.Nome = model.Nome;
            editBook.ISBN = model.ISBN;
            editBook.DataLancamento = model.DataLancamento;
            editBook.CategoriaId = model.CategoriaId;
            _repository.Update(editBook);

            return RedirectToAction("Index");
        }

    }
}