using Preventa.Contracts.Sistema.Tablas.Catalogo;
using Preventa.Modelos.Sistema.Tablas.Catalogo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Preventa.DataAccess.Sistema.Tablas.Catalogo
{
    public class RepositorioClienteContacto : RepositorioBase<ClienteContacto>, IRepositorioClienteContacto
    {
        public RepositorioClienteContacto(Contexto repositorioContexto) : base(repositorioContexto)
        {

        }

        public void ActualizarClienteContacto(ClienteContacto modelo)
        {
            ActualizarClienteContacto(modelo);
        }

        public void CrearClienteContacto(ClienteContacto modelo)
        {
            CrearClienteContacto(modelo);
        }

        public void EliminarClienteContacto(ClienteContacto modelo)
        {
            modelo.Activo = false;
            EliminarClienteContacto(modelo);
        }
    }
}
