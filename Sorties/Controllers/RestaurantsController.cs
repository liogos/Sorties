using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Sorties.Models;
using Sorties.Models.Repository;
using Sorties.Models.DAO.impl;
using Sorties.Models.DAO;

namespace Sorties.Controllers
{
    public class RestaurantsController : Controller
    {
        private BddContextSorties db = new BddContextSorties();
        private RestaurantsDAO rl;

        public RestaurantsController()
        {
            rl = new RestaurantsLinq();
        }
        // GET: Restaurants
        public ActionResult Index()
        {
            return View(db.Restaurants.ToList());
        }

        // GET: Restaurants
        public ActionResult findRestoByLocalite(int id)
        {
           return View(rl.findRestaurantsByLocalite(id).ToList());
        }
        // GET: Restaurants/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Restaurants restaurants = db.Restaurants.Find(id);
            if (restaurants == null)
            {
                return HttpNotFound();
            }
            return View(restaurants);
        }


    }
}
