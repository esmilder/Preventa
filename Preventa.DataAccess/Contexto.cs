//using Microsoft.EntityFrameworkCore;
//using Microsoft.Extensions.Configuration;
//using System;
//using System.Collections.Generic;
//using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Preventa.Modelos.Sistema.Tablas;
using Preventa.Modelos.Sistema.Tablas.Catalogo;
using Preventa.Modelos.Sistema.Tablas.Preventa;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Preventa.DataAccess
{
    public class Contexto: DbContext
    {
        public static class ContextDB
        {
            public static string CadenaConexionInicial { get; set; }
        }
        private string CadenaConexion { get; set; }

        public Contexto(DbContextOptions opciones): base (opciones)
        {
            var constructor = new ConfigurationBuilder();
            constructor.AddJsonFile("appsettings.json", optional: false);

            var configuracion = constructor.Build();
            CadenaConexion = configuracion.GetConnectionString("BDP").ToString();
            ContextDB.CadenaConexionInicial = configuracion.GetConnectionString("BDP").ToString();
        }


        protected override void OnModelCreating(ModelBuilder constructorModelo)
        {
            base.OnModelCreating(constructorModelo);
        }
        //protected override void OnConfiguring(DbContextOptionsBuilder opcionesConstructor)
        //{
        //    opcionesConstructor.UseSqlServer(CadenaConexion);
        //}
        public override async Task<int> SaveChangesAsync(CancellationToken tokenCancelacion = default)
        {
            var ListaEntradas = ChangeTracker.Entries().Where(x => x.Entity is EntidadBase);

            ListaEntradas.ToList().ForEach(delegate (Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry EntradaEntidad)
            {
                EntidadBase Entidad = EntradaEntidad.Entity as EntidadBase;

                if (EntradaEntidad.State == EntityState.Added)
                {
                    Entidad.RegistroFecha = DateTime.Now;
                    Entidad.RegistroUsuario = "";
                }
            });

            return await base.SaveChangesAsync();
        }

        #region DbSet Sistema
            #region Tablas
                #region Catálogos
                public DbSet<Cliente> Cliente { get; set; }
                public DbSet<ClienteContacto> ClienteContacto { get; set; }
                public DbSet<Producto> Producto { get; set; }
                public DbSet<Categoria> Categoria { get; set; }
                //public DbSet<ListaPrecioEncabezado> ListaPrecioEncabezado { get; set; }
                //public DbSet<ListaPrecioDetalle> ListaPrecioDetalle { get; set; }
            
            
                #endregion
            
                #region Preventa
                public DbSet<PreventaEncabezado> PreventaEncabezado { get; set; }
                public DbSet<PreventaDetalle> PreventaDetalle { get; set; }
                #endregion
            #endregion
        #endregion
    }
}
