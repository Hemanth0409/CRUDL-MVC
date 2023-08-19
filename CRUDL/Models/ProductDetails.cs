using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CRUDL.Models
{
    public class ProductDetails
    {
        [Required]
        public int ProId { get; set; }
        [Required(ErrorMessage ="Enter Product Name")]
        [StringLength(20,MinimumLength =3,ErrorMessage ="Name length must be more than 3")]
        [RegularExpression(@"^([A-Za-z ]+)$")]
        public string ProName { get; set; }
        [Required(ErrorMessage = "Price")]
        public int Price { get; set; }
        [Required(ErrorMessage = "Department")]
        public dept DeptName { get; set; }

    }
    public enum dept
    {
        Snacks,
        Drinks,
        Vegetable,
        fruits 
    }
}