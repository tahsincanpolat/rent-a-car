using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.ORM.Entity
{
    public class Arabalar : BaseEntity
    {
        [Required]
        public string Plaka { get; set; }
        [Required]
        public string Marka { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        public string AracTipi { get; set; }
        [Required]
        public string Vites { get; set; }
        [Required]
        public string YakitTipi { get; set; }
        public string ImageUrl { get; set; }
        [Required]
        public double Fiyat { get; set; }

        List<Yoneticiler> yoneticilers = new List<Yoneticiler>();
    }
}
