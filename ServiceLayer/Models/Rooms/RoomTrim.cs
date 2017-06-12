using KappaChat.ServiceLayer.Models.Users;
using ServiceLayer.Models.Messages;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Threading.Tasks;

namespace KappaChat.ServiceLayer.Models.Rooms
{
    public class RoomTrim
    {
        public RoomTrim (int roomId,ImmutableArray<UserTrim> occupants, ImmutableArray<MessageTrim> messages)
        {
            this.RoomId = roomId;
            this.Occupants = occupants;
            this.Messages = messages;
        }

        int RoomId { get; set; }
        ImmutableArray<UserTrim> Occupants { get; set; }
        ImmutableArray<MessageTrim> Messages { get; set; }
    }
}
