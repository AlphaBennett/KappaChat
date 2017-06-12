using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KappaChat.ServiceLayer.Models.Users
{
    public class UserActivity
    {
        public UserActivity()
        {
            this.IsTyping = false;
            this.LastActive = new DateTime();
            this.LastView = new DateTime();
        }

        bool IsTyping { get; set; }
        DateTime LastActive { get; set; }
        DateTime LastView { get; set; }
    }
}
