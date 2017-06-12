using KappaChat.ServiceLayer.Models.Users;
using ServiceLayer.Models.Messages;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Threading.Tasks;

namespace KappaChat.ServiceLayer.Models.Rooms
{
    public class Room
    {
        public Room(int roomId, string name, bool priv, ImmutableArray<User> mods, ImmutableArray<User> occupants, ImmutableArray<Message> messages)
        {
            this.RoomId = roomId;
            this.Name = name;
            this.Private = priv;
            this.Mods = mods;
            this.Occupants = occupants;
            this.Messages = messages;
        }

        int RoomId { get; set; }
        string Name { get; set; }
        bool Private { get; set; }
        ImmutableArray<User> Mods { get; set; }
        ImmutableArray<User> Occupants { get; set; }
        ImmutableArray<Message> Messages { get; set; }
    }
}
