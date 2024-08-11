using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastrutcure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastrutcureDI(this IServiceCollection services)
        {
            return services;
        }
    }
}
