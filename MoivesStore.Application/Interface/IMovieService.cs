using MoivesStore.Contract.DTOs.Movie;

namespace MoivesStore.Application.Interface
{
    public interface IMovieService
    {
        public Task<List<MovieDto>> GetAllMoviesAsync();
        public Task<MovieDto> CreateMovieAsync(MovieCreateDto movie);

    }
}