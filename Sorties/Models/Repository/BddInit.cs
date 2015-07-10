using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace Sorties.Models.Repository
{
    public class BddInit : DropCreateDatabaseAlways<BddContextSorties>
    {
        private string EncodeMD5(string motDePasse)
        {
            string motDePasseSel = "ChoixResto" + motDePasse + "ASP.NET MVC";
            return BitConverter.ToString(new MD5CryptoServiceProvider().ComputeHash(ASCIIEncoding.Default.GetBytes(motDePasseSel)));
        }

        protected override void Seed(BddContextSorties context)
        {
            Localites l1 = new Localites { Id = 1, cp = 1300, localite = "Wavre" };
            Localites l2 = new Localites { Id = 2, cp = 1410, localite = "Waterloo" };
            Localites l3 = new Localites { Id = 3, cp = 1420, localite = "Braine l'alleud" };
            Localites l4 = new Localites { Id = 4, cp = 1310, localite = "La Hulpe" };
            context.Localites.Add(l1);
            context.Localites.Add(l2);
            context.Localites.Add(l3);
            context.Localites.Add(l4);

            context.TypeCuisine.Add(new TypeCuisine { Id = 1, type = "Française" });
            context.TypeCuisine.Add(new TypeCuisine { Id = 2, type = "Asiatique" });
            context.TypeCuisine.Add(new TypeCuisine { Id = 3, type = "Italienne" });

            context.Restaurants.Add(new Restaurants { Id = 1, Nom = "Resto Mabienrempli", Telephone = "0012369874", Email = "restomabienrempli@gmail.com", adresse = "rue des roses 89", Localite = l1 });
            context.Restaurants.Add(new Restaurants { Id = 1, Nom = "Le dindon farceur",  Telephone = "0282369874", Email = "dindonfarceur@gmail.com", adresse = "rue des tulipes 89", Localite =l4});
            context.Restaurants.Add(new Restaurants { Id = 1, Nom = "La bonne bouffe",    Telephone = "0623698721", Email = "bonnebouffe@gmail.com", adresse = "rue des elephants 29", Localite = l3 });

            base.Seed(context);
        }
    }
}