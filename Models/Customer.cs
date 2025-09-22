using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.model
{
    //we have two CustomerType 
    public enum CustomerType { Normal, vip }
    internal class Customer : User
    {
        public static int idcount = 0;
        public Customer(CustomerType customerType = CustomerType.Normal)
        {
            type = customerType;
            creatAt = DateTime.Now;
            idcount += 66458;
            Id = idcount;
            orders = new List<Order>();
        }
        public string viasainfo { get; set; }
        DateTime creatAt { get; set; }
         public List<Order> orders { get; set; }
        public CustomerType type { get; set; }
        public override Role access()
        {
            return Role.Customer;
        }

        
    }
    
}
