using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kruemmel_monsters
{
    class Message
    {
        private string type;
        public string Type
        {
            get
            {
                return this.type;
            }
        }
        private string sender;
        public string Sender
        {
            get
            {
                return this.sender;
            }
        }
        private string receiver;
        public string Receiver
        {
            get
            {
                return this.receiver;
            }
        }
        private string Content { get; set; }

        public Message(string type, string sender, string receiver, string content)
        {
            this.type = type;
            this.sender = sender;
            this.receiver = receiver;
            this.Content = content;
        }

        public Message (string type, string sender, string receiver)
        {
            this.type = type;
            this.sender = sender;
            this.receiver = receiver;
        }
    }
}
