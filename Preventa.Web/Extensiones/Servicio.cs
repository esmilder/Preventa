using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Preventa.DataAccess;


namespace Preventa.Web.Extensiones
{
    public static class Servicio
    {
        public static void ConfiguracionRepositorioWrapper(this IServiceCollection servicios)
        {
            //servicios.AddScoped<IRepositorioWrapper, RepositorioWrapper>();

            servicios.AddScoped<Contracts.Sistema.Tablas.IRepositorioWrapper, DataAccess.Sistema.RepositorioWrapper>();
        }
        public static void ConfiguracionContextoSql(this IServiceCollection servicios, IConfiguration configuracion)
        {
            var CadenaConexion = configuracion["ConnectionStrings:BDP"];
            servicios.AddDbContext<Contexto>(o => o.UseSqlServer(CadenaConexion));
        }
    }
}
