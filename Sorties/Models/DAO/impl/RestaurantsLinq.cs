using Sorties.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sorties.Models.DAO.impl
{
    public class RestaurantsLinq : RestaurantsDAO
    {
        private BddContextSorties bdd;

        public RestaurantsLinq()
        {
            bdd = new BddContextSorties();
        }

        void IDisposable.Dispose()
        {
            bdd.Dispose();
        }

        List<Restaurants> RestaurantsDAO.findRestaurantsByLocalite(int idl)
        {
            return bdd.Restaurants.Where(resto => resto.Localite.Id == idl).ToList();
        }

        List<Restaurants> RestaurantsDAO.findRestaurantsByType(TypeCuisine t)
        {
            throw new NotImplementedException();
        }

        List<Restaurants> RestaurantsDAO.getAllRestaurants()
        {
            return bdd.Restaurants.ToList();
        }
    }
}