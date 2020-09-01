using FirstPage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstPage.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random   
        public ActionResult Random()    
        {
            var movie = new Movie() { Name = "Shrek!" };
                   return View(movie);
            /* return Content("Hello!");
             return new EmptyResult();
             return HttpNotFound();*/
            //return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });
        }
    }
}