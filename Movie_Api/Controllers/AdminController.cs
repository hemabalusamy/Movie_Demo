using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Movie_Api.Models;
using Movie_Api.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movie_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly ImovieRepository _imovieRepository;
        public AdminController(ImovieRepository imovieRepository)
        {
            _imovieRepository = imovieRepository;
        }
        [HttpGet]
        public async Task<IEnumerable<Movie>> GetMovies()
        {
            return await _imovieRepository.Get();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Movie>> GetMovies(int id)
        {
            return await _imovieRepository.Get(id);
        }
        [HttpPost]
        public async Task<ActionResult<Movie>>PostMovies([FromBody] Movie movie)
        {
            var newbook = await _imovieRepository.Create(movie);
            return CreatedAtAction(nameof(GetMovies), new { id = newbook.id }, newbook);
        }
        [HttpPut]
        public async Task<ActionResult> PutMovies(int id,[FromBody] Movie movie)
        {
            if(id!=movie.id)
            {
                return BadRequest();
            }
            await _imovieRepository.Update(movie);

            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var movietodelete = await _imovieRepository.Get(id);
            if(movietodelete==null)
            {
                return NotFound();
            }
            await _imovieRepository.Delete(movietodelete.id);
            return NoContent();
        }
    }
}
