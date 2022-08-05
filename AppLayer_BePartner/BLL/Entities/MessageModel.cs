using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities
{
    public class MessageModel
    {
        public int MsgId { get; set; }
        public string Sender { get; set; }
        public string Receiver { get; set; }
        public string Message { get; set; }
        public string Status { get; set; }
        public string Ttime { get; set; }
    }
}
