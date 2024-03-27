using Microsoft.Extensions.DependencyInjection;
using MoivesStore.Application.Interface;
using MoivesStore.Application.Services;

namespace MoivesStore.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IMovieService, MovieService>();
            return services;
        }
    }
}