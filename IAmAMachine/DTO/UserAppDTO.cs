using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAmAMachine.DTO
{
    public class UserAppDTO
    {
        public UserAppDTO()
        {
        }

        public UserAppDTO(string username, string userPassword, string userAuth)
        {
            Username = username;
            UserPassword = userPassword;
            UserAuth = userAuth;
        }

        public string Username { get; set; }
        public string UserPassword { get; set; }
        public string UserAuth { get; set; }
    }
}
