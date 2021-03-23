using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineSalesProducts.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="La Descripcion es requerida")]
        [MaxLength(100)]

        public string Description { get; set; }



    }
}
