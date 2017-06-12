using KappaChat.ServiceLayer.Models.Rooms;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceLayer.Models.Responses
{
    public class RoomsRequest
    {
        public RoomsRequest(int userId, DateTime lastSync)
        {
            this.UserId = userId;
            this.LastSync = lastSync;
        }
        int UserId { get; set; }
        DateTime LastSync { get; set; }
    }
}
