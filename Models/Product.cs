using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.model
{
    public class Product
    {
        public Product(string Name , double Price, int quntity)
        {
            this.Name = Name;
            this.Price = Price;
            this.quntity = quntity;

        }
        public int Id { get; set; }
        public int quntity { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public DateTime creatAt { get; set; }
    }
}
