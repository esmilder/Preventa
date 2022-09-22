using Preventa.Modelos.Sistema.Tablas.Preventa;
using System;
using System.Collections.Generic;
using System.Text;

namespace Preventa.Contracts.Sistema.Tablas.Preventa
{
    public interface IRepositorioPreventaDetalle //: IRepositorioBase<ICollection<PreventaDetalle>>
    {
        void CrearDetalleFactura(ICollection<PreventaDetalle> detallePreventa);

        void ActualizarDetalleFactura(ICollection<PreventaDetalle> detallePreventa);
    }
}
