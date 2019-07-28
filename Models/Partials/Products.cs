using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace BootstrapTest.Models
{
    [MetadataType(typeof(ProductsMD))]
    public partial class Products
    {
        public class ProductsMD
        {
            public int ProductID { get; set; }
            [Display(Name = "商品名稱")]
            public string ProductName { get; set; }
            public Nullable<int> SupplierID { get; set; }
            public Nullable<int> CategoryID { get; set; }
            [Display(Name = "單位數量")]
            public string QuantityPerUnit { get; set; }
            [Display(Name = "單價")]
            public Nullable<decimal> UnitPrice { get; set; }
            [Display(Name = "庫存量")]
            public Nullable<short> UnitsInStock { get; set; }
            [Display(Name = "訂購單位")]
            public Nullable<short> UnitsOnOrder { get; set; }
            [Display(Name = "重新訂購等級")]
            public Nullable<short> ReorderLevel { get; set; }
            [Display(Name = "停產")]
            public bool Discontinued { get; set; }            

            [JsonIgnore()]
            public virtual Categories Categories { get; set; }

            [JsonIgnore()]
            public virtual ICollection<Order_Details> Order_Details { get; set; }

            [JsonIgnore()]
            public virtual Suppliers Suppliers { get; set; }
        }
    }
}