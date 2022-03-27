using System;
using System.Collections.Generic;
using System.Text;

namespace Anton_John_Order_System
{
    class User
    {
        public string UserId { get; set; }

        public string Password { get; set; }

        public bool LoginStatus { get; set; }

        public void verifyLogin(string UserId, string Password)
        {
            if(UserId == this.UserId && Password == this.Password)
            {
                this.LoginStatus = true;
            }
        }

    }
}
