using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace Application
{
    public static class DependancyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {

            var assembly = typeof(DependancyInjection).Assembly;

            services.AddMediatR(configuration =>
                    configuration.RegisterServicesFromAssemblies(
                        typeof(DependancyInjection).Assembly));

            services.AddValidatorsFromAssembly(assembly);

            return services;

        }
    }
}
