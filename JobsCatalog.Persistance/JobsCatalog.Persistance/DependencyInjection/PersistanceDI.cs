using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobsCatalog.Persistance.Context;
using JobsCatalog.Application.Contracts.Persistance;

namespace JobsCatalog.Persistance.DependencyInjection
{
    public static class PersistanceDI
    {
        public static IServiceCollection AddPersistance(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<JobsCatalogDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("JobsCatalogConnection")));
            services.AddScoped<IJobsCatalogDbContext, JobsCatalogDbContext>();
            return services;
        }
    }
}
