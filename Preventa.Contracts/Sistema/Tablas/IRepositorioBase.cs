using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Preventa.Contracts.Sistema.Tablas
{
    public interface IRepositorioBase<T>
    {
        IQueryable<T> BuscarTodo();
        IQueryable<T> BuscarPorCondicion(Expression<Func<T, bool>> expression);
        void Crear(T entidad);
        void Actualizar(T entidad);
        void Eliminar(T entidad);
        void CrearConLista(ICollection<T> entidad);
        void ActualizarConLista(ICollection<T> entidad);
        void EliminarConLista(ICollection<T> entidad);
    }
}
