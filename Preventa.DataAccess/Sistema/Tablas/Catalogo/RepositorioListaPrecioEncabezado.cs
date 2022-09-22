using Preventa.Contracts.Sistema.Tablas.Catalogo;
using Preventa.Modelos.Sistema.Tablas.Catalogo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Preventa.DataAccess.Sistema.Tablas.Catalogo
{
    public class RepositorioListaPrecioEncabezado : RepositorioBase<ListaPrecioEncabezado>, IRepositorioListaPrecioEncabezado
    {
        public RepositorioListaPrecioEncabezado(Contexto repositorioContexto) : base(repositorioContexto)
        {

        }
        public void ActualizarListaPrecioEncabezado(ListaPrecioEncabezado modelo)
        {
            ActualizarListaPrecioEncabezado(modelo);
        }

        public void CrearListaPrecioEncabezado(ListaPrecioEncabezado modelo)
        {
            CrearListaPrecioEncabezado(modelo);
        }

        public void EliminarListaPrecioEncabezado(ListaPrecioEncabezado modelo)
        {
            modelo.Activo = false;
            EliminarListaPrecioEncabezado(modelo);
        }
    }
}
