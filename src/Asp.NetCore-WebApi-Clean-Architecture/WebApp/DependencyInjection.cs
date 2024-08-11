using Application;
using Infrastrutcure;

namespace WebApi
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddWebApiDI(this IServiceCollection services)
        {
            services.AddApplicationDI()
                .AddInfrastrutcureDI();

            return services;
        }
       
    }
}
