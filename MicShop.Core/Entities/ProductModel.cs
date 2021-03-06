﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MicShop.Core.Entities
{
    public class ProductModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public double OldPrice { get; set; }
        public string Sku { get; set; }
        public CategoryModel Category { get; set; }
        public string ImageBase64 { get; set; }
        [NotMapped]
        public IFormFile Image { get; set; }
    }
}
