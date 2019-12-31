using System;
namespace TheBridalStore.WebApi.Models
{
    public class Products
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }

        public string IsAvailable { get; set; }

        public string[] ImageUrls { get; set; }

        public Products()
        {

        }
    }
}
