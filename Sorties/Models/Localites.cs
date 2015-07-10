using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Sorties.Models
{
    public class Localites
    {
        public int Id { get; set; }
        [Required]
        public int cp { get; set; }
        [Required]
        public string localite { get; set; }

        public static implicit operator Localites(int v)
        {
            throw new NotImplementedException();
        }
    }
}