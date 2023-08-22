using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CRUDL.Models
{
    public class CompanyProp
    {
        public int Id { get; set; }
        [Required]
        public string CompanyName { get; set; }
        public string CompanyDescription { get; set;}
        public string CompanyPhone { get; set;}
        public string CompanyEmail { get; set;}
   
    }
}