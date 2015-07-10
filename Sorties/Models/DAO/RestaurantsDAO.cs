using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sorties.Models.DAO
{
    public interface RestaurantsDAO : IDisposable
    {
        List<Restaurants> getAllRestaurants();
        List<Restaurants> findRestaurantsByLocalite(int l);
        List<Restaurants> findRestaurantsByType(TypeCuisine t);
    }
}