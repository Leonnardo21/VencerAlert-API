using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using VencerAlert.Domain.Abstractions;
using VencerAlert.Infrastructure.Context;
using VencerAlert.Infrastructure.Repositories;

namespace VencerAlert.CrossCutting.DependenciesApp
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services,
            IConfiguration configuration) {

            var connectionString = configuration.GetConnectionString("Sqlite");

            services.AddDbContext<AppDbContext>(opt => opt.UseSqlite(connectionString));

            services.AddScoped<IProductRepository, ProductRepository>();

            return services;
        }
    }
}
