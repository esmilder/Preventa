using Preventa.Modelos.Sistema.Tablas.Catalogo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Preventa.Contracts.Sistema.Tablas.Catalogo
{
    public interface IRepositorioClienteContacto: IRepositorioBase<ClienteContacto>
    {
        void CrearClienteContacto(ClienteContacto modelo);
        void ActualizarClienteContacto(ClienteContacto modelo);
        void EliminarClienteContacto(ClienteContacto modelo);
    }
}
