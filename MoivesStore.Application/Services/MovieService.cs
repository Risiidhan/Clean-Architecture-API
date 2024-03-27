using MoivesStore.Application.Interface;
using MoivesStore.Contract.DTOs.Movie;
using MoivesStore.Contract.Interfaces;

namespace MoivesStore.Application.Services
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _movieRepository;
        public MovieService(IMovieRepository movieRepository)
        {
            this._movieRepository = movieRepository;
        }

        public Task<MovieDto> CreateMovieAsync(MovieCreateDto movie)
        {
            return _movieRepository.CreateMovieAsync(movie);
        }

        public Task<List<MovieDto>> GetAllMoviesAsync()
        {
            return _movieRepository.GetAllMoviesAsync();
        }
    }
}