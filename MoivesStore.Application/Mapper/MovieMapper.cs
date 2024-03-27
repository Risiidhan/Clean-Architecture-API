
using MoivesStore.Contract.DTOs.Movie;
using MoivesStore.Domain.Models;

namespace MoivesStore.Application.Mapper
{
    public class MovieMapper
    {
        public static MovieDto ToMovieDto(Movies movie) => new MovieDto
        {
            Id = movie.Id,
            Name = movie.Name,
            ReleasedYear = movie.ReleasedYear,
            IsMyFavourite = movie.IsMyFavourite,
        };

         public static Movies ToMovie(MovieCreateDto moviedto) => new Movies
        {
            Name = moviedto.Name,
            ReleasedYear = moviedto.ReleasedYear,
            IsMyFavourite = moviedto.IsMyFavourite,
        };
    }
}