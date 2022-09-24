using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Preventa.Contracts.Sistema.Tablas;
using Preventa.Modelos.Sistema.Tablas.Catalogo;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Preventa.Web.Controllers
{
    public class ProductoController : Controller
    {
        private IConfiguration configuracion;
        private IRepositorioWrapper _RepositorioWrapper;
        public ProductoController(IRepositorioWrapper _repositorioWrapper, IConfiguration _configuration)
        {
            configuracion = _configuration;
            _RepositorioWrapper = _repositorioWrapper;
        }
        // GET: ProductoController
        public async Task<ActionResult> Index()
        {
            List<Producto> productos = new List<Producto>();
            productos = await _RepositorioWrapper.Producto.BuscarPorCondicion(t => t.Activo).ToListAsync();
            var categoria = _RepositorioWrapper.Categoria.BuscarTodo();
            foreach (var item in productos)
            {
                item.Categoria = categoria.Where(t => t.Id == item.IdCategoria).FirstOrDefault();
            }
            return View(productos);
        }

        // GET: ProductoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProductoController/Create
        public ActionResult Create()
        {
            var categorias = _RepositorioWrapper.Categoria.BuscarPorCondicion(x => x.Activo).Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.Descripcion }).ToList();


            ViewData["ListaCategoria"] = categorias;
            return View();
        }

        // POST: ProductoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Producto producto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    producto.Activo = true;
                    //categoria.Activo = true;

                    _RepositorioWrapper.Producto.Crear(producto);
                    await _RepositorioWrapper.GuardarAsync();
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    var categorias = _RepositorioWrapper.Categoria.BuscarPorCondicion(x => x.Activo).Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.Descripcion }).ToList();
                    ViewData["ListaCategoria"] = categorias;
                    return View(producto);
                }
            }
            catch
            {
                return NotFound();
            }
        }

        // GET: ProductoController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {

            Producto producto = await _RepositorioWrapper.Producto.BuscarPorCondicion(t => t.Id == id).FirstOrDefaultAsync();

            if (producto == null)
                return BadRequest("No se ha encontrado este producto");

            producto.Categoria = await _RepositorioWrapper.Categoria.BuscarPorCondicion(t => t.Id == producto.IdCategoria).FirstAsync();

            var categorias = _RepositorioWrapper.Categoria.BuscarPorCondicion(x => x.Activo).Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.Descripcion }).ToList();

            ViewData["ListaCategoria"] = categorias;
            return View(producto);
        }

        // POST: ProductoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(Producto producto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var productoBd = await _RepositorioWrapper.Producto.BuscarPorCondicion(t=> t.Id== producto.Id).FirstOrDefaultAsync();

                    productoBd.PrecioUnitario= producto.PrecioUnitario;
                    productoBd.Descripcion= producto.Descripcion;
                    productoBd.Excento= producto.Excento;
                    productoBd.IdCategoria= producto.IdCategoria;

                    _RepositorioWrapper.Producto.Actualizar(productoBd);
                    await _RepositorioWrapper.GuardarAsync();
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    var categorias = _RepositorioWrapper.Categoria.BuscarPorCondicion(x => x.Activo).Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.Descripcion }).ToList();
                    ViewData["ListaCategoria"] = categorias;
                    return View(producto);
                }
            }
            catch
            {
                return NotFound();
            }
        }

        // GET: ProductoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProductoController/Delete/5
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
