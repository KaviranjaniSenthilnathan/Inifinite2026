using System.Collections.Generic;
using MoviesMVC.Models;

namespace MoviesMVC.Repository
{
    public interface IMovieRepository
    {
        List<Movies> GetAll();
        Movies GetById(int id);
        void Add(Movies movie);
        void Update(Movies movie);
        void Delete(int id);
        List<Movies> GetByDirector(string director);
        List<Movies> GetByYear(int year);
    }
}
