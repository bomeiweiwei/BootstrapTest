using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace BootstrapTest.Models
{
    [MetadataType(typeof(SuppliersMD))]
    public partial class Suppliers
    {
        public class SuppliersMD
        {
            public int SupplierID { get; set; }
            [Display(Name = "公司名稱")]
            public string CompanyName { get; set; }
            public string ContactName { get; set; }
            public string ContactTitle { get; set; }
            public string Address { get; set; }
            public string City { get; set; }
            public string Region { get; set; }
            public string PostalCode { get; set; }
            public string Country { get; set; }
            public string Phone { get; set; }
            public string Fax { get; set; }
            public string HomePage { get; set; }

            [JsonIgnore()]
            public virtual ICollection<Products> Products { get; set; }
        }
    }
}