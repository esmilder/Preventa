using Preventa.Contracts.Sistema.Tablas.Preventa;
using Preventa.Modelos.Sistema.Tablas.Preventa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Preventa.DataAccess.Sistema.Tablas.Preventa
{
    public class RepositorioPreventaDetalle : RepositorioBase<PreventaDetalle>,IRepositorioPreventaDetalle
    {
        public RepositorioPreventaDetalle(Contexto repositorioContexto) : base(repositorioContexto)
        {

        }
        public void ActualizarDetalleFactura(ICollection<PreventaDetalle> detallePreventa)
        {
            ActualizarDetalleFactura(detallePreventa);
        }

        public void CrearDetalleFactura(ICollection<PreventaDetalle> detallePreventa)
        {
            CrearDetalleFactura(detallePreventa);
        }
    }
}
