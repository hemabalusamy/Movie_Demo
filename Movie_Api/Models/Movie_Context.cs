using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movie_Api.Models
{
    public class Movie_Context:DbContext
    {
        public Movie_Context(DbContextOptions<Movie_Context> options)
            :base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Movie> Movies { get; set; }
    }
}
