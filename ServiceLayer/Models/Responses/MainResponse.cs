using KappaChat.ServiceLayer.Models.Rooms;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceLayer.Models.Responses
{
    public class MainResponse
    {
        public MainResponse(ImmutableArray<RoomTrim> rooms, DateTime lastSync)
        {
            this.Rooms = rooms;
            this.LastSync = lastSync;
        }
        ImmutableArray<RoomTrim> Rooms { get; set; }
        DateTime LastSync { get; set; }
    }
}
