using System;
using System.Collections.Generic;
using System.Text;

namespace ShopSolution.Data.Entities
{
    public class Language
    {
        public string Id { set; get; }
        public string Name { set; get; }
        public bool IsDefault { set; get; }
        public List<CategoryTranslation> CategoryTranslations { get; set; }
        public List<ProductTranslation> ProductTranslations { get; set; }
    }
}
