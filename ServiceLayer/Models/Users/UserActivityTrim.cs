using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KappaChat.ServiceLayer.Models.Users
{
    public class UserActivityTrim
    {
        public UserActivityTrim()
        {
            this.IsTyping = false;
            this.LastView = new DateTime();
        }

        bool IsTyping { get; set; }
        DateTime LastView { get; set; }
    }
}
