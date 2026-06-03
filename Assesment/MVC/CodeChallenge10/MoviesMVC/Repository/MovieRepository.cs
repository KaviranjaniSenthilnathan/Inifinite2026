using System.Collections.Generic;
using System.Linq;
using MoviesMVC.Models;

namespace MoviesMVC.Repository
{
    public class MovieRepository : IMovieRepository
    {
        private static List<Movies> movies = new List<Movies>();

        public List<Movies> GetAll()
        {
            return movies;
        }

        public Movies GetById(int id)
        {
            return movies.FirstOrDefault(x => x.Mid == id);
        }

        public void Add(Movies movie)
        {
            movie.Mid = movies.Count + 1;
            movies.Add(movie);
        }

        public void Update(Movies movie)
        {
            var m = GetById(movie.Mid);
            if (m != null)
            {
                m.MovieName = movie.MovieName;
                m.DirectorName = movie.DirectorName;
                m.DateOfRelease = movie.DateOfRelease;
            }
        }

        public void Delete(int id)
        {
            var m = GetById(id);
            if (m != null)
                movies.Remove(m);
        }

        public List<Movies> GetByDirector(string director)
        {
            return movies.Where(x => x.DirectorName == director).ToList();
        }

        public List<Movies> GetByYear(int year)
        {
            return movies.Where(x => x.DateOfRelease.Year == year).ToList();
        }
    }
}
