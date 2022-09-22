using Preventa.Modelos.Sistema.Tablas.Catalogo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Preventa.Contracts.Sistema.Tablas.Catalogo
{
    public interface IRepositorioProducto : IRepositorioBase<Producto>
    {
        void CrearProducto(Producto modelo);
        void ActualizarProducto(Producto modelo);
        void EliminarProducto(Producto modelo);
    }
}
