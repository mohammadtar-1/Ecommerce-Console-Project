using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.model
{
    internal class Order
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description{ get; set; }
        
        public Customer customer { get; set; }

        public DateTime creatat { get; set; }
        
        public DateTime updated { get; set; }
        public List<Product> Products { get; set; }
        
        public void getBill(CustomerType type)
        {
            Console.WriteLine($"the bill for customer{customer.Name}");

            int i = 0;
            double sum = 0;
            foreach (var item in Products)
            {
                sum += item.Price;
                Console.WriteLine($"{++i}-Product with name{item.Name}with id{item.Id}with Price{item.Price}");
            }
            Console.WriteLine($"the sum of all product is:{sum}");
            Console.WriteLine($"yoer discount :{Discount.getdiscount(customerType: type)}");
            Console.WriteLine($"the final pric after discount :{sum - sum * Discount.getdiscount(customer.type)}");
        }
        

    }
}
