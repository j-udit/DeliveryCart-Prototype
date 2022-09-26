using System.ComponentModel.DataAnnotations;

namespace RazorPagesDeliveryCart.Models
{
    public class Store
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }
}