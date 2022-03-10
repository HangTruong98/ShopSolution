using System;
using System.Collections.Generic;
using System.Text;

namespace ShopSolution.Data.Entities
{
    public class Language
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public bool IsDefault { set; get; }
    }
}
