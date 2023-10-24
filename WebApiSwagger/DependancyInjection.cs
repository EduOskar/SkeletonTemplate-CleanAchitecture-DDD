using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace WebApiSwagger;

public static class DependancyInjection
{
    public static IServiceCollection AddWebApiSwagger(this IServiceCollection services)
    {

        return services;

    }
}
