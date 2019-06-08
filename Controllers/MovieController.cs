using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignWeb.Models;
using Microsoft.AspNetCore.Mvc;
 

namespace DesignWeb.Controllers
{
    public class MovieController:Controller
    {
         public IActionResult Index()
        {
            return View();
        }

        public IActionResult List(int? id)
        {
            var movies = MovieRepository.Movies;

            if (id != null)
            {
                movies = movies.Where(i => i.CategoryId == id).ToList();
            }

            return View(movies);
        }
    }
}