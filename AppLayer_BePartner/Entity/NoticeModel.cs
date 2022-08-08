using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class NoticeModel
    {
        public int Notice_Id { get; set; }

        public string Subject { get; set; }

        public string Description { get; set; }

        public System.DateTime Issue_time { get; set; }

        public System.DateTime Due_time { get; set; }

        public string Status { get; set; }
    }
}
