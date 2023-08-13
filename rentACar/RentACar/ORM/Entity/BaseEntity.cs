using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.ORM.Entity
{
    public abstract class BaseEntity
    {
        [Required]
        public int ID { get; set; }

        public DateTime? AddDate = DateTime.Now;
        
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }

        [Required]
        public bool AktifMi { get; set; }
    }
}
