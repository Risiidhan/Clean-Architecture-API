using MoivesStore.Contract.DTOs.Movie;

namespace MoivesStore.Contract.Interfaces
{
    public interface IMovieRepository
    {
        public Task<List<MovieDto>> GetAllMoviesAsync();
        public Task<MovieDto> CreateMovieAsync(MovieCreateDto movie);

    }
}