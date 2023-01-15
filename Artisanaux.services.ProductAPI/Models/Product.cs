﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Artisanaux.services.ProductAPI.Models
{
   // [Table("Products")]
    public class Product
    {   
        [Key]
        public int ProductId { get; set; }
        [Required, StringLength(25)]
        public string ProductName { get; set; }
        [Range(1, 1000)]
        public Double Price { get; set; }
        public string CategoryName { get; set; }
        public string ImageURL { get; set; }
    }
}
