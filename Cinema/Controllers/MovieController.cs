using Cinema.Models;
using Core.Interfaces;
using Core.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Controllers
{
    [Authorize]
    public class MovieController : Controller
    {
        private readonly IBusinessLayer bl;
        public MovieController(IBusinessLayer businessLayer)
        {
            this.bl = businessLayer;
        }
        [Route("Mvi/Index", Order = 1)]
        [Route("Movie/Index", Order = 2)]
        public IActionResult Index()
        {
            var model = bl.FetchMovies();
            return View(model);
        }

        //GET Movie/Details/{id}
        [HttpGet("Movie/details/{id}")]
        public IActionResult Details(int id)
        {
            //Validazione dell'input
            if (id <= 0)
            {
                return View("Error", new ErrorViewModel());
            }

            //Recupero film da visualizzare
            var mvi = bl.GetMovieById(id);

            //Restituzione della vista (check del modello)
            if (mvi == null)
            {
                return View("NotFound", new NotFoundViewModel()
                {
                    EntityId = id,
                    Message = "Something wrong"
                });
            }
            return View(mvi);
        }
       

        [Authorize(Policy = "AccountAdministrator")]
        //GET
        public IActionResult Create()
        {
            return View();
        }
        [Authorize(Policy = "AccountAdministrator")]
        [HttpPost]
        public IActionResult Create(MovieViewModel data)
        {
            //validazione
            if (data == null)
            {
                return View("Error", new ErrorViewModel());
            }
            if (ModelState.IsValid)
            {
                //chiamata al business layer
                MovieResult result = bl.AddNewMovie(new Movie
                {
                    Name = data.Name,
                    Length = data.Length,
                    Type = data.Type,
                    ReleaseDate = data.ReleaseDate
                });
                //restituzione della view
                if (result.Success)
                {
                    return RedirectToAction("Index");
                }
            }
            return View();
        }
        public IActionResult Edit(int id)
        {
            if (id <= 0)
            {
                return View("Error", new ErrorViewModel());
            }

            //recupero l'impiegato da modificare
            var model = bl.GetMovieById(id);
            if (model == null)
            {
                return View("NotFound", new NotFoundViewModel { EntityId = id, Message = "Sorry, not found" });
            }
            var flmViewModel = new MovieViewModel
            {
                Id = model.Id,
                Name = model.Name,
                Length = model.Length,
                Type = model.Type,
                ReleaseDate = model.ReleaseDate

            };

            return View(flmViewModel);
        }

        [HttpPost]
        public IActionResult Edit(MovieViewModel data)
        {
            if (data == null)
            {
                return View("Error", new ErrorViewModel());
            }

            var result = bl.EditMovie(new Movie
            {
                Id = data.Id,
                Name = data.Name,
                Length = data.Length,
                Type = data.Type,
                ReleaseDate = data.ReleaseDate

            });
            if (result.Success)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult Delete(int id)
        {
            //... GUARDIA SULL'ID
            var model = bl.GetMovieById(id);
            //guardia sul model
            return View(model);
        }
        [HttpPost]
        public IActionResult Delete(Movie data)
        {
            var movieToDelete = bl.GetMovieById(data.Id);

            var result = bl.DeleteMovie(movieToDelete);
            if (result.Success)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
