//David Petersson Ramvall
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Web;

namespace DavidPR_MVC_Tenta.Models
{
    public class Store
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Product> Products { get; set; }
    }
}