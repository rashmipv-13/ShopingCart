using ShopingCart.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopingCart.Services
{
    public class UserRepo : IUserRepo
    {
        public IEnumerable<User> GetCustomerOrderDetails(int CustID)
        {
            var userOrderDetails = UserMemorymanagement.GetUser(CustID);
            return userOrderDetails;

        }

        public void SaveCustomerOrderDetails(User user)
        {
            UserMemorymanagement.AddUser(user);
        }
    }
}
