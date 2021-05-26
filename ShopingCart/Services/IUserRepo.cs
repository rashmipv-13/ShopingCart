using ShopingCart.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopingCart.Services
{
   public interface IUserRepo
    {
        IEnumerable<User> GetCustomerOrderDetails(int CustID);
        void SaveCustomerOrderDetails(User user);
    }
}
