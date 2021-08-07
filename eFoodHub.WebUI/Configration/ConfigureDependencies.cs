using eFoodHub.Services.Implementations;
using eFoodHub.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eFoodHub.WebUI.Configration
{
    public class ConfigureDependencies
    {
        public static void AddServices(IServiceCollection services)
        {
            services.AddScoped<IAuthenticationServices, AuthenticationServices>();
        }
    }
}
