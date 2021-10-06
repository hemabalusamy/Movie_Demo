using Movie_Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movie_Api.Repository
{
   public  interface ImovieRepository
    {
        Task<IEnumerable<Movie>> Get();
        Task<Movie> Get(int id);
        Task<Movie> Create(Movie movie);
        Task Update(Movie movie);
        Task Delete(int id);
    }
}
