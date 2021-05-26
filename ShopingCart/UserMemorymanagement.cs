using ShopingCart.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopingCart
{
    public static class UserMemorymanagement
    {
        public static List<User> lstUser = new List<User>();

        public static IEnumerable<User> GetUser(int id)
        {
           var user =  lstUser.Where(x => x.Id == id);
            return user;
        }

        public static void AddUser(User user)
        {
            lstUser.Add(user);

        }


    }
}
