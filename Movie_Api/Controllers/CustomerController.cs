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
    public class CustomerController : ControllerBase
    {
        private readonly ImovieRepository _imovieRepository;
        public CustomerController(ImovieRepository imovieRepository)
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
       
    }
}
