using Microsoft.AspNetCore.Mvc;
using MoivesStore.Application.Interface;
using MoivesStore.Contract.DTOs.Movie;

namespace MoivesStore.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MovieController : ControllerBase
    {
        private readonly IMovieService _movieService;
        public MovieController(IMovieService movieService)
        {
            this._movieService = movieService;
        }
         
        [HttpGet]
        public async Task<IActionResult> GetAllMovie()
        {
            var movies = await _movieService.GetAllMoviesAsync();
            return Ok(movies);
        }

        [HttpPost]
        public async Task<IActionResult> CreateMovie([FromBody] MovieCreateDto movieCreateDto)
        {
            var createdMovie = await _movieService.CreateMovieAsync(movieCreateDto);
            return Ok(createdMovie);
        }
    }
}