using Application.Courses;
using Intefaces.Application;
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
            Applicacion(servicios);
        }

        private static void Applicacion(IServiceCollection services) 
        {
            services.AddScoped<IQuerys, Queries>();
        }

        private static void Contexts(IServiceCollection services)
        {
            services.RegisterContext<IPersistenceContext, OnlineCoursesContext>();
        }
    }
}
