
using Preventa.Modelos.Sistema.Tablas.Preventa;
using System;
using System.Collections.Generic;
using System.Text;

namespace Preventa.Contracts.Sistema.Tablas.Preventa
{
    public interface IRepositorioPreventaEncabezado : IRepositorioBase<PreventaEncabezado>
    {
        void CrearPreventaEncabezado(PreventaEncabezado modelo);
        void ActualizarPreventaEncabezado(PreventaEncabezado modelo);
        void EliminarPreventaEncabezado(PreventaEncabezado modelo);
    }
}
