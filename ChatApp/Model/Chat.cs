using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatApp.Model
{
    public class Chat
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public string Message { get; set; }
    }

    public class User
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
