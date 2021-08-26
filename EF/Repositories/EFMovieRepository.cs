using Core.Interfaces;
using Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EF.Repositories
{
    public class EFMovieRepository : IMovieRepository
    {
        private readonly MovieContext ctx;
        public EFMovieRepository(MovieContext context)
        {
            this.ctx = context;
        }

        public bool AddItem(Movie newItem)
        {
            if (newItem == null)
            {
                throw new ArgumentNullException("Invalide item");
            }
            try
            {
                ctx.Movies.Add(newItem);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("Invalide id");
            }
            try
            {
                var itemToDelete = GetById(id);
                if (itemToDelete != null)
                {
                    ctx.Movies.Remove(itemToDelete);
                    ctx.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool EditItem(Movie itemToEdit)
        {
            if (itemToEdit == null)
            {
                throw new ArgumentNullException("Invalide item");
            }
            try
            {
                ctx.Entry(itemToEdit).State = EntityState.Modified;
                ctx.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<Movie> FetchAll()
        {
            try
            {
                return ctx.Movies.ToList();//toList e di lik
            }
            catch (Exception)
            {

                return null;
            }
        }

        public Movie GetById(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("Invalid id");
            }
            try
            {
                return ctx.Movies.FirstOrDefault(x => x.Id == id);
            }
            catch (Exception)
            {
                return null;

            }
        }
    }
}
