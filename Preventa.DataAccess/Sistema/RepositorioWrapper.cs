using Preventa.Contracts.Sistema.Tablas;
using Preventa.Contracts.Sistema.Tablas.Catalogo;
using Preventa.Contracts.Sistema.Tablas.Preventa;
using Preventa.DataAccess.Sistema.Tablas.Catalogo;
using Preventa.DataAccess.Sistema.Tablas.Preventa;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Preventa.DataAccess.Sistema
{
    public class RepositorioWrapper: IRepositorioWrapper
    {
        private Contexto _repositorioContexto;

        private IRepositorioCategoria categoria;
        private IRepositorioCliente cliente;
        private IRepositorioClienteContacto clienteContacto;
        private IRepositorioProducto producto;
        private IRepositorioListaPrecioDetalle listaPrecioDetalle;
        private IRepositorioListaPrecioEncabezado listaPrecioEncabezado;
        private IRepositorioPreventaEncabezado preventaEncabezado;
        private IRepositorioPreventaDetalle preventaDetalle;

        public IRepositorioCategoria Categoria
        {
            get
            {
                if (categoria == null)
                    categoria = new RepositorioCategoria(_repositorioContexto);
                return categoria;
            }
        }
        public IRepositorioCliente Cliente
        {
            get
            {
                if (cliente == null)
                    cliente = new RepositorioCliente(_repositorioContexto);
                return cliente;
            }
        }
        public IRepositorioClienteContacto ClienteContacto
        {
            get
            {
                if (clienteContacto == null)
                    clienteContacto = new RepositorioClienteContacto(_repositorioContexto);
                return clienteContacto;
            }
        }
        public IRepositorioProducto Producto
        {
            get 
            {
                if (producto == null)
                    producto = new RepositorioProducto(_repositorioContexto);
                return producto;
            }
        }
        public IRepositorioListaPrecioEncabezado ListaPrecioEncabezado
        {
            get
            {
                if (listaPrecioEncabezado == null)
                    listaPrecioEncabezado = new RepositorioListaPrecioEncabezado(_repositorioContexto);
                return listaPrecioEncabezado;
            }
        }
        public IRepositorioListaPrecioDetalle ListaPrecioDetalle
        {
            get
            {
                if (listaPrecioDetalle == null)
                    listaPrecioDetalle = new RepositorioListaPrecioDetalle(_repositorioContexto);
                return listaPrecioDetalle;
            }
        }
        public IRepositorioPreventaEncabezado PreventaEncabezado
        {
            get
            {
                if (preventaEncabezado == null)
                    preventaEncabezado = new RepositorioPreventaEncabezado(_repositorioContexto);
                return preventaEncabezado;
            }
        }
        public IRepositorioPreventaDetalle PreventaDetalle
        {
            get
            {
                if (preventaDetalle == null)
                    preventaDetalle = new RepositorioPreventaDetalle(_repositorioContexto);
                return preventaDetalle;
            }
        }

        public RepositorioWrapper(Contexto contexto)
        {
            _repositorioContexto = contexto;
        }
        public async Task GuardarAsync() 
        {
            await _repositorioContexto.SaveChangesAsync();
        }
    }
}
