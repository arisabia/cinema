using Core.Interfaces;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Mock
{
    public class MockMovieRepository : IMovieRepository
    {
        private static List<Movie> movies = new List<Movie>()
        {

                new Movie
                {
                    Id=1,
                    Name = "Lost",
                    Length = 120,
                    Type = "Drama",
                    ReleaseDate = new DateTime(2000,2,3)
                },
                 new Movie
                {
                    Id=2,
                    Name = "Titanic",
                    Length = 120,
                    Type = "Drama",
                    ReleaseDate = new DateTime(1996,2,3)
                }
         };
        public bool AddItem(Movie newItem)
        {
            if (newItem == null)
            {
                throw new ArgumentNullException("Invalide item");
            }

            var lastId = FetchAll().Last().Id;
            newItem.Id = ++lastId;
            FetchAll().Add(newItem);
            return true;
        }

        public bool Delete(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("Invalid id");
            }
            var movieToDelete = FetchAll().FirstOrDefault(e => e.Id == id);
            if (movieToDelete == null)
            {
                throw new ArgumentNullException("Invalid item");
            }

            FetchAll().Remove(movieToDelete);
            return true;
        }

        public bool EditItem(Movie itemToEdit)
        {
            if (itemToEdit == null)
            {
                throw new ArgumentNullException("Invalid item");
            }
            var oldItem = FetchAll().FirstOrDefault(e => e.Id == itemToEdit.Id);
            FetchAll().Remove(oldItem);
            AddItem(itemToEdit);
            return true;
        }

        public List<Movie> FetchAll()
        {
            return movies;
        }

        public Movie GetById(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("Invalid id");
            }
            return FetchAll().FirstOrDefault(e => e.Id == id);
        }
    }
}
