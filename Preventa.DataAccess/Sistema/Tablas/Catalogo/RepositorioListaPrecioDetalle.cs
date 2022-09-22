using Preventa.Contracts.Sistema.Tablas.Catalogo;
using Preventa.Modelos.Sistema.Tablas.Catalogo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Preventa.DataAccess.Sistema.Tablas.Catalogo
{
    public class RepositorioListaPrecioDetalle : RepositorioBase<ListaPrecioDetalle>, IRepositorioListaPrecioDetalle
    {
        public RepositorioListaPrecioDetalle(Contexto repositorioContexto) : base(repositorioContexto)
        {

        }
        public void ActualizarListaPrecioDetalle(ListaPrecioDetalle modelo)
        {
            ActualizarListaPrecioDetalle(modelo);
        }

        public void CrearListaPrecioDetalle(ListaPrecioDetalle modelo)
        {
            CrearListaPrecioDetalle(modelo);
        }

        //public void EliminarListaPrecioDetalle(ListaPrecioDetalle modelo)
        //{
            
        //}
    }
}
