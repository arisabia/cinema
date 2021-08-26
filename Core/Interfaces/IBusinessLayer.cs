using Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Interfaces
{
   public interface IBusinessLayer
    {
        IEnumerable<Movie> FetchMovies ();
        Movie GetMovieById(int id);
        MovieResult AddNewMovie(Movie newMovie);
        MovieResult EditMovie(Movie data);
        MovieResult DeleteMovie(Movie data);
        Account GetAccount(string username);
    }
}
