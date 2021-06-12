using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Into the Bad Lnadfs" };
            return View(movie);
        }
        public ActionResult ByReleaseDate(int year, int month)
        { 
            return Content(year + "/" + month);
        }
    }
}