﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ShopSolution.Data.Entities
{
 
    public class Product
    {
        public int Id { set; get; }
        public decimal Price {set; get;}
        public decimal OriginalPrice {set; get;}
        public int Stock {set; get;}
        public int ViewCount {set; get;}
        public DateTime DateCreated {set; get;}

        //public string SeoAlias {set; get;}
    }
}
