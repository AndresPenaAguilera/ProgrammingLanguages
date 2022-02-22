using Intefaces.Persistence;
using Microsoft.Extensions.DependencyInjection;
using Persistence;

namespace Resolver
{
    public static class Resolver
    {
        public static void AddServices(this IServiceCollection servicios)
        {
            Contexts(servicios);
        }

        private static void Contexts(IServiceCollection services)
        {
            services.RegistrarContexto<IPersistenceContext, OnlineCoursesContext>();
        }
    }
}
