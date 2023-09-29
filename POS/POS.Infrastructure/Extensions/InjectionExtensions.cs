using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using POS.Infrastructure.Persistences.Context;

namespace POS.Infrastructure.Extensions
{
    // Inyeccion de Dependencia de la cadena de Conexion a la BD
    public static class InjectionExtensions
    {
        public static IServiceCollection AddInjectionInfrastruture( this IServiceCollection servies,
            IConfiguration configuration)
        {
            var assembly = typeof(PosContext).Assembly.FullName;

            servies.AddDbContext<PosContext>(
                options => options.UseSqlServer(
                    configuration.GetConnectionString("POSConnection"), b => 
                    b.MigrationsAssembly(assembly)), ServiceLifetime.Transient);
            return servies;
        }
    }
}
