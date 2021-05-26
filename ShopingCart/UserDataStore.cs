using ShopingCart.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopingCart
{
    public class UserDataStore
    {
        public List<User> lstUser;

        public List<User> getUser()
        {
            lstUser = new List<User>()
            {
            new User()
            {
                Id = 1,
                Name = "Jack",
                OrderID = new List<Order>
                {
                    new Order()
                    {
                         Id = 1,
                Name = "tShirt",
                Cost = "100"
                    },
                    new Order()
                    {
                         Id = 2,
                Name = "JPAnt",
                Cost = "200"
                    }

                }
            },
              new User()
             {
                 Id = 2,
                 Name = "Angela",
                 OrderID = new List<Order>
                {
                    new Order()
                    {
                         Id = 1,
                Name = "tShirt",
                Cost = "100"
                    }


                }
             }
            };

            return lstUser;
        }
    }
    }
