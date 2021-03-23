using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineSalesProducts.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="La Descripcion es requerida")]
        [Display(Name ="Descripcion")]
        public string Description { get; set; }

        [Required(ErrorMessage ="El Titulo es requerido")]
        [Display(Name = "Titulo del Producto")]
        public string Title { get; set; }
        [Required(ErrorMessage ="El Precio es requerido")]
        [Display(Name = "Precio")]
        public decimal Price { get; set; }
        [Display(Name = "Categoria")]
        [Required(ErrorMessage ="Debe seleccionar una categoria")]
        public int CategoryId { get; set; }

    }
}
