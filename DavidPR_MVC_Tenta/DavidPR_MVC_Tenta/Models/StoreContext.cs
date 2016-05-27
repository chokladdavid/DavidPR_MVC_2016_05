using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DavidPR_MVC_Tenta.Models
{
    public class StoreContext : DbContext
    {
        public DbSet<Store> Stores { get; set; }
        public DbSet<Product> Products { get; set; }

        

        //public StoreContext() : base ("MVC_Tenta_DB")
        //{
        //    StoreInitializer();
        //}

        //private void StoreInitializer() : DropCreateDatabaseAlways<StoreContext> 
        //{
            
        //    List<Store> stores = new List<Store>()
        //    {
        //        new Store() {ID = 1, Name = "Fruit Store", Address = "Golden Street",
        //            Products = new List<Product>(){
        //                new Product() {ID = 1, Store_ID = 1, Name = "Banana", ProductText = "A gulenboj", ProductNumber = 10, Price = 3.0M, ProductsInStock = 40},
        //                new Product() {ID = 2, Store_ID = 1, Name = "Apple", ProductText = "A Big Apple", ProductNumber = 20, Price = 3.0M, ProductsInStock = 30}
        //            }
        //        },
        //        new Store() {ID = 2, Name = "Tool Store", Address = "Hammer Street",
        //            Products = new List<Product>(){
        //                new Product() {ID = 3, Store_ID = 2, Name = "Hammer", ProductText = "A hammer to hitt nails with.", ProductNumber = 12, Price = 65.12M, ProductsInStock = 12},
        //                new Product() {ID = 4, Store_ID = 2, Name = "Nails", ProductText = "Nails to get hit py a hammer.", ProductNumber = 13, ProductsInStock = 9999}
        //            } }
        //    };
        //    foreach (var store in stores)
        //    {
                
        //    }
        //}
    }
}