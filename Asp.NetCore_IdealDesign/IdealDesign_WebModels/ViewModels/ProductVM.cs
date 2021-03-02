using IdealDesign_WebModels.EnumsVM;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace IdealDesign_WebModels.VewModels
{
    public class ProductVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        //[Display(Name="Product Type")]
        public ProductTypeVM ProductType { get; set; }                
    }
}
