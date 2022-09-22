using Preventa.Modelos.Sistema.Tablas.Catalogo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Preventa.Contracts.Sistema.Tablas.Catalogo
{
    public interface IRepositorioListaPrecioDetalle: IRepositorioBase<ListaPrecioDetalle>
    {
        void CrearListaPrecioDetalle(ListaPrecioDetalle modelo);
        void ActualizarListaPrecioDetalle(ListaPrecioDetalle modelo);
        //void EliminarListaPrecioDetalle(ListaPrecioDetalle modelo);
    }
}
