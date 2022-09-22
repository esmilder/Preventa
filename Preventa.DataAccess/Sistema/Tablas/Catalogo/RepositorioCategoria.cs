using Preventa.Contracts.Sistema.Tablas.Catalogo;
using Preventa.Modelos.Sistema.Tablas.Catalogo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Preventa.DataAccess.Sistema.Tablas.Catalogo
{
    public class RepositorioCategoria : RepositorioBase<Categoria>, IRepositorioCategoria
    {
        public RepositorioCategoria(Contexto repositorioContexto):base(repositorioContexto)
        {

        }
        public void ActualizarCategoria(Categoria modelo)
        {
            ActualizarCategoria(modelo);
        }

        public void CrearCategoria(Categoria modelo)
        {
            CrearCategoria(modelo);
        }

        public void EliminarCategoria(Categoria modelo)
        {
            modelo.Activo = false;
            EliminarCategoria(modelo);
        }
    }
}
