using Microsoft.EntityFrameworkCore;
using MoivesStore.Application.Mapper;
using MoivesStore.Contract.DTOs.Movie;
using MoivesStore.Contract.Interfaces;
using MoivesStore.Domain.Models;
using MoivesStore.Infrastructure.Data;

namespace MoivesStore.Infrastructure.Repository
{
    public class MovieRepository : IMovieRepository
    {
        private readonly ApplicationDBContext _context;
        public MovieRepository(ApplicationDBContext context)
        {
            this._context = context;
            
        }
        public async Task<List<MovieDto>> GetAllMoviesAsync()
        {
            var movies =  await _context.Movie.ToListAsync();
            return movies.Select(m => MovieMapper.ToMovieDto(m)).ToList();
        }

        public async Task<List<Movies>> GetAllMovieAsync()
        {
            return await _context.Movie.ToListAsync();
        }

        public async Task<MovieDto> CreateMovieAsync(MovieCreateDto movie)
        {
            if (movie == null)
                throw new ArgumentNullException(nameof(movie));

            var movieModel = MovieMapper.ToMovie(movie);
            await _context.Movie.AddAsync(movieModel);
            await _context.SaveChangesAsync();

            var movieDto = MovieMapper.ToMovieDto(movieModel);
            return movieDto;
        }
    }
}