using Preventa.Contracts.Sistema.Tablas.Catalogo;
using Preventa.Modelos.Sistema.Tablas.Catalogo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Preventa.DataAccess.Sistema.Tablas.Catalogo
{
    public class RepositorioCliente : RepositorioBase<Cliente>, IRepositorioCliente
    {
        public RepositorioCliente(Contexto repositorioContexto) : base(repositorioContexto)
        {

        }

        public void ActualizarCliente(Cliente modelo)
        {
            ActualizarCliente(modelo);
        }

        public void CrearCliente(Cliente modelo)
        {
            CrearCliente(modelo);
        }

        public void EliminarCliente(Cliente modelo)
        {
            modelo.Activo = false;
            EliminarCliente(modelo);
        }
    }
}
