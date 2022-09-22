using Preventa.Contracts.Sistema.Tablas.Catalogo;
using Preventa.Modelos.Sistema.Tablas.Catalogo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Preventa.DataAccess.Sistema.Tablas.Catalogo
{
    public class RepositorioProducto : RepositorioBase<Producto>, IRepositorioProducto
    {
        public RepositorioProducto(Contexto repositorioContexto) : base(repositorioContexto)
        {

        }

        public void ActualizarProducto(Producto producto)
        {
            ActualizarProducto(producto);
        }

        public void CrearProducto(Producto producto)
        {
            CrearProducto(producto);
        }

        public void EliminarProducto(Producto producto)
        {
            producto.Activo = false;
            EliminarProducto(producto);
        }
    }
}
