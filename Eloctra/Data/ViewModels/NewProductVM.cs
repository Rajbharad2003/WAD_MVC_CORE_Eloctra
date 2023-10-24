﻿using Eloctra.Data;
using Eloctra.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Eloctra.Models
{
    public class NewProductVM
    {
        public int Id { get; set; }

        [Display(Name = "Product name")]
        [Required(ErrorMessage = "Product Name is required")]
        public string Name { get; set; }

        [Display(Name = "Product description")]
        [Required(ErrorMessage = "Product Description is required")]
        public string Description { get; set; }

        [Display(Name = "Price in Rs.")]
        [Required(ErrorMessage = "Price is required")]
        public double Price { get; set; }

        [Display(Name = "Product image URL")]
        [Required(ErrorMessage = "Product image URL is required")]
        public string ImageURL { get; set; }


        [Display(Name = "Select a category")]
        [Required(ErrorMessage = "Product category is required")]
        public Category Category { get; set; }

        //Relationships
        [Display(Name = "Select a company")]
        [Required(ErrorMessage = "Product company is required")]
        public int CompanyId { get; set; }

    }
}
