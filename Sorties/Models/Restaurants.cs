using ChoixResto.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sorties.Models
{
    public class Restaurants
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Le nom du restaurant doit être saisi")]
        [Remote("VerifNomResto", "Restaurant", ErrorMessage = "Ce nom de restaurant existe déjà")]
        [StringLength(20)]
        public string Nom { get; set; }

        [RegularExpression(@"^0[0-9]{9}$", ErrorMessage = "Le numéro de téléphone est incorrect")]
        [RestoValidator(Parametre1 = "Telephone", Parametre2 = "Email", ErrorMessage = "Vous devez saisir au moins un moyen de contacter le restaurant")]
        [Display(Name = "Téléphone")]
        public string Telephone { get; set; }
        [RestoValidator(Parametre1 = "Telephone", Parametre2 = "Email", ErrorMessage = "Vous devez saisir au moins un moyen de contacter le restaurant")]
        public string Email { get; set; }
        [Display(Name = "Site internet")]
        public string Web { get; set; }
        [Required]
        public string adresse { get; set; }
        [Display(Name = "Localité")]
        [Required]
        public virtual Localites Localite { get; set; }


    }
}