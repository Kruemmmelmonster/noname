using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kruemmel_monsters
{
    class Message
    {
        string type { get; set; }
        string sender { get; }
        string receiver { get; }
        string content { get; set; }
    }
}
