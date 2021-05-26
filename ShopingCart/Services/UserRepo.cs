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
            UserDataStore db = new UserDataStore();
            var userOrderDetails = db.getUser().Where(x => x.Id == CustID);
            return userOrderDetails;

        }
    }
}
