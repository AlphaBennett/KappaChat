using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceLayer.Models.Messages
{
    public class PrivateMessage
    {
        public PrivateMessage(int messageId, int senderId, int receiverId, DateTime time, string text)
        {
            this.MessageId = messageId;
            this.SenderId = senderId;
            this.ReceiverId = receiverId;
            this.Time = time;
            this.Text = text;
        }

        int MessageId { get; set; }
        int SenderId { get; set; }
        int ReceiverId { get; set; }
        DateTime Time { get; set; }
        string Text { get; set; }

    }
}
