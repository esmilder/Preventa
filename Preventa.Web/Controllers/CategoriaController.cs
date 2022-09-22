using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Preventa.Contracts.Sistema.Tablas;
using Preventa.Modelos.Sistema.Tablas.Catalogo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Preventa.Web.Controllers
{
    public class CategoriaController : Controller
    {
        private IConfiguration configuracion;
        private IRepositorioWrapper _RepositorioWrapper;
        public CategoriaController(IRepositorioWrapper _repositorioWrapper, IConfiguration _configuration)
        {
            configuracion = _configuration;
            _RepositorioWrapper = _repositorioWrapper;
        }
        // GET: CategoriaController
        public async Task<ActionResult> Index()
        {
            List<Categoria> ListaCategoria = new List<Categoria>();
            ListaCategoria = await _RepositorioWrapper.Categoria.BuscarTodo().ToListAsync();// BuscarPorCondicion(x => x.Activo).ToList();
            return View(ListaCategoria);
        }

        // GET: CategoriaController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CategoriaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoriaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CategoriaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CategoriaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CategoriaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CategoriaController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
