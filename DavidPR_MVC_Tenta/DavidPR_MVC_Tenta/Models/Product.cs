//David Petersson Ramvall

using System.ComponentModel.DataAnnotations;
using System.Security.AccessControl;

namespace DavidPR_MVC_Tenta.Models
{
    public class Product
    {
        public int ID { get; set; }
        public int Store_ID { get; set; }
        [Required, MaxLength(20)]
        public string Name { get; set; }
        [Required, MaxLength(50)]
        public string ProductText { get; set; }
        [PNumValid]
        public string ProductNumber { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public int ProductsInStock { get; set; }
    }
}