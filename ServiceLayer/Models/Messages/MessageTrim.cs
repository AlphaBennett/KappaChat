using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceLayer.Models.Messages
{
    public class MessageTrim
    {
        public MessageTrim(int senderId, DateTime time, string text)
        {
            this.SenderId = senderId;
            this.Time = time;
            this.Text = text;
        }
        
        int SenderId { get; set; }
        DateTime Time { get; set; }
        string Text { get; set; }

    }
}
