using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Sorties.Models.Repository
{

    public class BddContextSorties : DbContext
    {
        public DbSet<Localites> Localites { get; set; }
        public DbSet<TypeCuisine> TypeCuisine { get; set; }
        public DbSet<Restaurants> Restaurants { get; set; }
    }
}