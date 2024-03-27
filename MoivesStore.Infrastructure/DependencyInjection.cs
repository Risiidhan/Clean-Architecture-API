using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MoivesStore.Contract.Interfaces;
using MoivesStore.Infrastructure.Data;
using MoivesStore.Infrastructure.Repository;

namespace MoivesStore.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, string? ConString)
        {
            services.AddScoped<IMovieRepository, MovieRepository>();
            services.AddDbContext<ApplicationDBContext>(options => options.UseSqlServer(ConString));
            return services;
        }
    }
}