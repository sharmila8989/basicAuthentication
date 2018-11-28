using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppDemoDB.Models
{
    public class UserManager
    {
        private DemoDBEntities _Context;

        public UserManager()
        {
            _Context = new DemoDBEntities();
        }

        public bool ValidateUser(string UserName, string Password)
        {
            var result = _Context.UserMasters.SingleOrDefault(x => x.UserName.Equals(UserName, StringComparison.OrdinalIgnoreCase) && x.Password == Password);
            return result != null ? true : false;
        }
    }
}