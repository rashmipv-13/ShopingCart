using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopingCart.Model
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Order> OrderID { get; set; }

    }
}
