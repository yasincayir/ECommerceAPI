using ECommerceAPI.Application.Abstractions;
using ECommerceAPI.Persistence.Concretes;
using ECommerceAPI.Persistence.Contexts;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ECommerceAPI.Persistence
{
    public static class ServiceRegistration
    {
        
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddSingleton<IProductService, ProductService>();
            services.AddDbContext<ECommerceApiDbContext>(options => options.UseNpgsql(Configuration.ConfigurationString));
        }
    }
}
