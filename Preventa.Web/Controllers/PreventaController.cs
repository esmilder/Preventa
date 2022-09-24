﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Preventa.Contracts.Sistema.Tablas;
using Preventa.Modelos.Sistema.Tablas.Catalogo;
using Preventa.Modelos.Sistema.Tablas.Preventa;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Preventa.Web.Controllers
{
    public class PreventaController : Controller
    {
        private IRepositorioWrapper _RepositorioWrapper;
        private readonly IConfiguration Configuracion;

        public PreventaController(IRepositorioWrapper repositorioWrapper, IConfiguration configuracion)
        {
            _RepositorioWrapper = repositorioWrapper;
            Configuracion = configuracion;
        }
        // GET: PreventaController
        public async Task<ActionResult> Index()
        {
            List<PreventaEncabezado> preventas = new List<PreventaEncabezado>();
            preventas = await _RepositorioWrapper.PreventaEncabezado.BuscarPorCondicion(x => x.Activo).ToListAsync();
            var clientes = await _RepositorioWrapper.Cliente.BuscarTodo().ToListAsync();
            foreach (var item in preventas)
            {
                item.Cliente = clientes.Where(t => t.Id == item.IdCliente).FirstOrDefault();
            }

            return View(preventas);
        }

        // GET: PreventaController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PreventaController/Create
        public ActionResult Create()
        {
            var Clientes = _RepositorioWrapper.Cliente.BuscarPorCondicion(x => x.Activo)
                .Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.Nombre }).ToList();
            var Productos = _RepositorioWrapper.Producto.BuscarPorCondicion(x => x.Activo).Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.Descripcion }).ToList();

            ViewData["ListaClientes"] = Clientes;
            ViewData["ListaProductos"] = Productos;

            return View();
        }

        // POST: PreventaController/Create
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

        // GET: PreventaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PreventaController/Edit/5
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

        // GET: PreventaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PreventaController/Delete/5
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




        [HttpGet]
        public async Task<JsonResult> ObtenerProducto(int idproducto)
        {
            Producto? oProducto = new Producto();
            oProducto = await _RepositorioWrapper.Producto.BuscarPorCondicion(t => t.Id == idproducto).FirstOrDefaultAsync();
            return Json(oProducto);
        }
    }
}
