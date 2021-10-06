using Microsoft.EntityFrameworkCore;
using Movie_Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movie_Api.Repository
{
    public class MovieRepository : ImovieRepository
    {
        private readonly Movie_Context movie1;
        public MovieRepository(Movie_Context context)
        {
            movie1 = context;
        }
        public async Task<Movie> Create(Movie movie)
        {
            movie1.Movies.Add(movie);
             await movie1.SaveChangesAsync();
            return movie;
        }

        public async Task Delete(int id)
        {
            var movietotable = await movie1.Movies.FindAsync(id);
            movie1.Movies.Remove(movietotable);
            await movie1.SaveChangesAsync();
        }

        public async Task<IEnumerable<Movie>> Get()
        {
            return await movie1.Movies.ToListAsync();
        }

        public async  Task<Movie> Get(int id)
        {
            return await movie1.Movies.FindAsync(id);
        }

        public async Task Update(Movie movie)
        {
            movie1.Entry(movie).State = EntityState.Modified;
            await movie1.SaveChangesAsync();

        }
    }
}
