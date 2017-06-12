using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KappaChat.ServiceLayer.Models.Users
{
    public class UserTrim
    {

        public UserTrim()
        {
            this.UserId = 0;
            this.UserActivity = null;
        }

        [JsonConstructor]
        public UserTrim(int userId, UserActivityTrim userActivity)
        {
            this.UserId = userId;
            this.UserActivity = userActivity;
        }

        
        int UserId { get; set; }
        UserActivityTrim UserActivity { get; set; }
    }
}
