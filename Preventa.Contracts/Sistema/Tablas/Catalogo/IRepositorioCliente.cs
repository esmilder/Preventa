using Preventa.Modelos.Sistema.Tablas.Catalogo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Preventa.Contracts.Sistema.Tablas.Catalogo
{
    public interface IRepositorioCliente: IRepositorioBase<Cliente>
    {
        void CrearCliente(Cliente modelo);
        void ActualizarCliente(Cliente modelo);
        void EliminarCliente(Cliente modelo);
    }
}
