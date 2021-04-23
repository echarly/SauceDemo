using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceDemo
{
    public class UserInformation
    {

        public string UserEmail { get; set; }
        public string UserPassword { get; set; }
        
        public UserInformation Valid_UserInformation()
        {
            UserEmail = "standard_user";
            UserPassword = "secret_sauce";

            return this;
        }

        public UserInformation InValid_UserInformation()
        {
            UserEmail = "standard_user";
            UserPassword = "invalid";

            return this;
        }

    }
}

public enum Users
{
    Valid,
    Invalid
}