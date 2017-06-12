using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceLayer.Models.Messages
{
    public class Message
    {
        public Message(int messageId, int senderId, int roomId, DateTime time, string text)
        {
            this.MessageId = messageId;
            this.SenderId = senderId;
            this.RoomId = roomId;
            this.Time = time;
            this.Text = text;
        }

        int MessageId { get; set; }
        int SenderId { get; set; }
        int RoomId { get; set; }
        DateTime Time { get; set; }
        string Text { get; set; }

    }
}
