using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using movie_catalog_api.Model;
using movie_catalog_api.Service;

namespace movie_catalog_api.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController: ControllerBase
    {
        private readonly IMovieService _moviesService;

        public MovieController(IMovieService movies)
        {
            _moviesService = movies;
        }

        /// <summary>
        /// Retorna todos os filmes da base.
        /// </summary>
        [HttpGet]
        public async Task<ActionResult<List<Movie>>> GetAllAsync()
        {
            var movies =  _moviesService.GetAll();
            return Ok(movies);
        }

        /// <summary>
        /// Retorna um filme pelo ID.
        /// </summary>
        [HttpGet("{id:length(24)}")] // ObjectId tem 24 caracteres hex
        public async Task<ActionResult<Movie>> GetByIdAsync(string id)
        {
            var movie = _moviesService.GetMovie(id);
            if (movie == null)
            {
                return NotFound();
            }
            return Ok(movie);
        }

        /// <summary>
        /// Insere um novo filme.
        /// </summary>
        [HttpPost]
        public async Task<ActionResult<string>> InsertAsync([FromBody] Movie request)
        {
            if (request == null)
                return BadRequest(new { message = "Invalid request body." });
            var response = _moviesService.AddMovie(request);
            return Ok(response);
        }
    }
}