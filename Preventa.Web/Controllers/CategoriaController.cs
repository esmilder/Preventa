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
            ListaCategoria = await _RepositorioWrapper.Categoria.BuscarPorCondicion(t => t.Activo).ToListAsync();// BuscarPorCondicion(x => x.Activo).ToList();
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
        public async Task<ActionResult> Create(Categoria categoria)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    categoria.Activo = true;
                    _RepositorioWrapper.Categoria.Crear(categoria);
                    await _RepositorioWrapper.GuardarAsync();
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    return View(categoria);
                }
            }
            catch
            {
                return NotFound();
            }
        }

        // GET: CategoriaController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            Categoria categoria = await _RepositorioWrapper.Categoria.BuscarPorCondicion(t => t.Id == id).FirstOrDefaultAsync();
            if (categoria == null)
                return BadRequest("No se ha encontrado esta categoria");
            return View(categoria);
        }

        // POST: CategoriaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(Categoria categoria)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var categoriaActualizar = await _RepositorioWrapper.Categoria.BuscarPorCondicion(t => t.Id == categoria.Id).FirstOrDefaultAsync();

                    categoriaActualizar.Descripcion = categoria.Descripcion;
                    _RepositorioWrapper.Categoria.Actualizar(categoriaActualizar);
                    await _RepositorioWrapper.GuardarAsync();
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    return View(categoria);
                }
            }
            catch (Exception ex)
            {
                ViewData["mensaje"] = $"Opps \"{ex.Message}\"";
                return View(categoria);
            }
        }

        // GET: CategoriaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CategoriaController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
        //[HttpDelete]
        //public async Task<ActionResult> EliminarCategoria(int idCategoria)
        //{
        //    try
        //    {
        //        var categoria = await _RepositorioWrapper.Categoria.BuscarPorCondicion(t => t.Id == idCategoria).FirstOrDefaultAsync(); ;
        //        if (categoria == null)
        //            return NotFound("Categoria no existe");
        //        categoria.Activo = false;
        //        _RepositorioWrapper.Categoria.Eliminar(categoria);
        //        await _RepositorioWrapper.GuardarAsync();

        //        //return View("Index");
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch (Exception ex)
        //    {
        //        return NotFound(ex.Message);
        //    }
        //}
        [HttpDelete]
        public async Task<JsonResult> EliminarCategoria(int idCategoria)
        {
            try
            {
                var categoria = await _RepositorioWrapper.Categoria.BuscarPorCondicion(t => t.Id == idCategoria).FirstOrDefaultAsync(); ;
                if (categoria == null)
                    return Json(new { respuesta = false });
                categoria.Activo = false;
                _RepositorioWrapper.Categoria.Eliminar(categoria);
                await _RepositorioWrapper.GuardarAsync();

                return Json(new { respuesta = true });
            }
            catch (Exception ex)
            {
                return Json(new { respuesta = false });
            }
        }
    }
}

