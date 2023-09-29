using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using POS.Infrastructure.Persistences.Context;
using POS.Infrastructure.Persistences.Interfaces;
using POS.Infrastructure.Persistences.Repositories;

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

            // COnfiguracion de patron unitofwork
            servies.AddTransient<IUnitOfWork, UnitOfWork>();

            return servies;
        }
    }
}
