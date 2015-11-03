using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kruemmel_monsters
{
    class Message
    {
        string Type { get; private set; }
        string Sender { get; private set; }
        string Receiver { get; private set; }
        string Content { get; set; }

        public Message(string type, string sender, string receiver, string content)
        {
            this.Type = type;
            this.Sender = sender;
            this.Receiver = receiver;
            this.Content = content;
        }

        public Message (string type, string sender, string receiver)
        {
            this.Type = type;
            this.Sender = sender;
            this.Receiver = receiver;
        }
    }
}
