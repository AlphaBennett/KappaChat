using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KappaChat.ServiceLayer.Models.Users
{
    public class User
    {

        public User()
        {
            this.UserId = 0;
            this.FirstName = string.Empty;
            this.LastName = string.Empty;
            this.Handle = string.Empty;
            this.Email = string.Empty;
 //           this.PassHash = string.Empty;
            this.UserActivity = null;
        }

        [JsonConstructor]
        public User(int userId, string firstName, string lastName, string handle, string email, /*string passHash,*/ UserActivity userActivity)
        {
            this.UserId = userId;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Handle = handle;
            this.Email = email;
 //           this.PassHash = passHash;
            this.UserActivity = userActivity;
        }

        
        int UserId { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string Handle { get; set; }
        string Email { get; set; }
  //      string PassHash { get; set; }
        UserActivity UserActivity { get; set; }
    }
}
