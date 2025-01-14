using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proiect.Models
{
    public class Produs
    {
        public int ID { get; set; }
        [Required, StringLength(150, MinimumLength = 3)]
        [Display(Name = "Product Name")]
        public string DenumireProdus { get; set; }
        public string Descriere { get; set; }
        [Range(1, 300)]
        [Column(TypeName = "decimal(6, 2)")]
        public decimal Pret { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Expiration Date")]
        public DateTime PublishingDate { get; set; }
        public int ProducatorID { get; set; }
        public Producator Producator { get; set; }
        [Display(Name = "Product Name")]
        public ICollection<CategorieProdus> CategoriiProdus { get; set; }
    }
}
