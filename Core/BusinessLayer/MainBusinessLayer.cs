using Core.Interfaces;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.BusinessLayer
{
    public class MainBusinessLayer : IBusinessLayer
    {
        private readonly IMovieRepository movieRepository;
        private readonly IAccountRepository accountRepository;
        public MainBusinessLayer(IMovieRepository movieRepo, IAccountRepository accountRepo)
        {
            this.movieRepository = movieRepo;
            this.accountRepository = accountRepo;
        }
        public MovieResult AddNewMovie(Movie newMovie)
        {
            if (newMovie == null)
            {
                throw new ArgumentNullException("Invalid item");
            }
            var result = movieRepository.AddItem(newMovie);
            if (result)
            {
                return new MovieResult
                {
                    Success = true,
                    Message = "Ok"
                };
            }
            return new MovieResult
            {
                Success = false,
                Message = $"Film {newMovie.Name} - {newMovie.Length} cannot be saved"
            };
        }

        public MovieResult DeleteMovie(Movie data)
        {
            if (data == null)
            {
                throw new ArgumentNullException("Order is invalide");
            }
            var result = movieRepository.Delete(data.Id);
            if (result)
            {
                return new MovieResult
                {
                    Success = true,
                    Message = ""
                };
            }

            return new MovieResult
            {
                Success = false,
                Message = "Cannot delete"
            };
        }

        public MovieResult EditMovie(Movie data)
        {
            if (data == null)
            {
                throw new ArgumentNullException("Invalid info");
            }

            var result = movieRepository.EditItem(data);
            if (result)
            {
                return new MovieResult
                {
                    Success = true,
                    Message = ""
                };
            }

            return new MovieResult
            {
                Success = false,
                Message = "Cannot edit"
            };
        }

        public IEnumerable<Movie> FetchMovies()
        {
            return movieRepository.FetchAll();
        }

        public Account GetAccount(string username)
        {
            if (String.IsNullOrEmpty(username))
            {
                throw new ArgumentException("Invalid username");
            }
            return accountRepository.GetByUsername(username);
        }

        public Movie GetMovieById(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("Invalid id");
            }
            return movieRepository.GetById(id);
        }
    }
}
