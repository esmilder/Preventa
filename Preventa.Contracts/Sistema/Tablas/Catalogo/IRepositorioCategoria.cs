using Preventa.Modelos.Sistema.Tablas.Catalogo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Preventa.Contracts.Sistema.Tablas.Catalogo
{
    public interface IRepositorioCategoria :IRepositorioBase<Categoria>
    {
        void CrearCategoria(Categoria modelo);
        void ActualizarCategoria(Categoria modelo);
        void EliminarCategoria(Categoria modelo);
    }
}
