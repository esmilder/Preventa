using Preventa.Contracts.Sistema.Tablas.Preventa;
using Preventa.Modelos.Sistema.Tablas.Preventa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Preventa.DataAccess.Sistema.Tablas.Preventa
{
    public class RepositorioPreventaEncabezado : RepositorioBase<PreventaEncabezado>, IRepositorioPreventaEncabezado
    {
        public RepositorioPreventaEncabezado(Contexto repositorioContexto):base(repositorioContexto)
        {

        }

        public void ActualizarPreventaEncabezado(PreventaEncabezado modelo)
        {
            ActualizarPreventaEncabezado(modelo);
        }

        public void CrearPreventaEncabezado(PreventaEncabezado modelo)
        {
            CrearPreventaEncabezado(modelo);
        }

        public void EliminarPreventaEncabezado(PreventaEncabezado modelo)
        {
            modelo.Activo = false;
            EliminarPreventaEncabezado(modelo);
        }
    }
}
