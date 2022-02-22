using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;



namespace Resolver
{

    public static class RegistrarContextoExtension
    {
        public static IServiceCollection RegistrarContexto<TContexto>(this IServiceCollection serviceCollection) where TContexto : DbContext
        {
            serviceCollection.AddDbContext<TContexto>((serviceProvider, dbContextOptionsBuilder) =>
            {
                var constructorConexion = serviceProvider.GetRequiredService<IConstructorConexion>();
                constructorConexion.Configurar(serviceProvider, dbContextOptionsBuilder);
            });
            return serviceCollection;
        }

        public static IServiceCollection RegistrarContexto<TIContexto, TContexto>(this IServiceCollection serviceCollection)
            where TContexto : DbContext, TIContexto where TIContexto : class
        {
            serviceCollection.RegistrarContexto<TContexto>();
            serviceCollection.AddScoped<TIContexto>(provider => provider.GetService<TContexto>());
            return serviceCollection;
        }
    }

    public class ConstructorConexion : IConstructorConexion
    {
        public void Configurar(IServiceProvider serviceProvider, DbContextOptionsBuilder options)
        {
            options.UseSqlServer(serviceProvider.GetService<ISesion>().CadenaConexion);
        }
    }

    public interface IConstructorConexion
    {
        void Configurar(IServiceProvider serviceProvider, DbContextOptionsBuilder options);
    }

    public interface ISesion
    {
        string CadenaConexion { get; }
    }


}
