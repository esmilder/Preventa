using Preventa.Modelos.Sistema.Tablas.Catalogo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Preventa.Contracts.Sistema.Tablas.Catalogo
{
    public interface IRepositorioListaPrecioEncabezado : IRepositorioBase<ListaPrecioEncabezado>
    {
        void CrearListaPrecioEncabezado(ListaPrecioEncabezado modelo);
        void ActualizarListaPrecioEncabezado(ListaPrecioEncabezado modelo);
        void EliminarListaPrecioEncabezado(ListaPrecioEncabezado modelo);
    }
}
