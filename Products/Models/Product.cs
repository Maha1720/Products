//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Products.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;

    public partial class Product
    {
        [Required]
        public int id { get; set; }

        [Required]
        public string ProductName { get; set; }
        public int CategoryID { get; set; }
        public int BrandID { get; set; }
        public string Description { get; set; }
        [Required]
        public Nullable<int> Quantity { get; set; }
        [Required]
        public Nullable<decimal> Price { get; set; }
    
        public virtual Brand Brand { get; set; }
        public virtual Category Category { get; set; }

       
    }
}
