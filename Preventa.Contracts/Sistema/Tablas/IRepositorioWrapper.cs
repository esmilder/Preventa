using Preventa.Contracts.Sistema.Tablas.Catalogo;
using Preventa.Contracts.Sistema.Tablas.Preventa;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Preventa.Contracts.Sistema.Tablas
{
    public interface IRepositorioWrapper
    {
        IRepositorioCategoria Categoria { get; }
        IRepositorioCliente Cliente { get; }
        IRepositorioClienteContacto ClienteContacto { get; }
        IRepositorioProducto Producto { get; }
        IRepositorioPreventaDetalle PreventaDetalle { get; }
        IRepositorioPreventaEncabezado PreventaEncabezado { get; }

        Task GuardarAsync();
    }
}
