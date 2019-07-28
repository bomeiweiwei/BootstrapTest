using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace BootstrapTest.Models
{
    [MetadataType(typeof(CategoriesMD))]
    public partial class Categories
    {
        public class CategoriesMD
        {
            public int CategoryID { get; set; }
            [Display(Name = "產品分類")]
            public string CategoryName { get; set; }
            public string Description { get; set; }
            public byte[] Picture { get; set; }

            [JsonIgnore()]
            public virtual ICollection<Products> Products { get; set; }
        }
    }
}