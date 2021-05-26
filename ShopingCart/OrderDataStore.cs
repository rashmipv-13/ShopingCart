using ShopingCart.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopingCart
{
    public class OrderDataStore
    {
        public Order getOrder(int OrderID)
        {
            var order = new Order()
            {
                Id = 1,
                Name = "tShirt",
                Cost = "100"
            };
            new Order()
            {
                Id = 2,
                Name = "JPAnt",
                Cost = "200"
            };
            new Order()
            {
                Id = 3,
                Name = "NigihtSuit",
                Cost = "500"
            };

            return order;
        }
    }
}
