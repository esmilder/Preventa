using Microsoft.EntityFrameworkCore;
using Preventa.Contracts.Sistema.Tablas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Preventa.DataAccess.Sistema
{
    public class RepositorioBase<T> : IRepositorioBase<T> where T : class
    {
        protected Contexto RepositorioContexto { get; set; }
        public RepositorioBase(Contexto repositorioContexto)
        {
            RepositorioContexto = repositorioContexto;
        }
        public void Actualizar(T entidad)
        {
            RepositorioContexto.Set<T>().Update(entidad);
        }

        public void ActualizarConLista(ICollection<T> entidad)
        {
            foreach (var item in entidad)
            {
                RepositorioContexto.Set<T>().Update(item);
            }
        }

        public IQueryable<T> BuscarPorCondicion(Expression<Func<T, bool>> expression)
        {
            return RepositorioContexto.Set<T>().Where(expression).AsNoTracking();
        }

        public IQueryable<T> BuscarTodo()
        {
            return RepositorioContexto.Set<T>().AsNoTracking();
        }

        public void Crear(T entidad)
        {
            RepositorioContexto.Set<T>().Add(entidad);
        }

        public void CrearConLista(ICollection<T> entidad)
        {
            foreach (var item in entidad)
            {
                RepositorioContexto.Set<T>().Add(item);
            }
        }

        public void Eliminar(T entidad)
        {
            RepositorioContexto.Set<T>().Update(entidad);
        }

        public void EliminarConLista(ICollection<T> entidad)
        {
            foreach (var item in entidad)
            {
                RepositorioContexto.Set<T>().Update(item);
            }
        }
    }
}
