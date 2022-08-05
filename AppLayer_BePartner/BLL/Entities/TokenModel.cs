using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities
{
    public class TokenModel
    {
        public int Id { get; set; }

        public string Tkey { get; set; }

        public System.DateTime CreatedAt { get; set; }

        public Nullable<System.DateTime> ExpiredAt { get; set; }

        public int User_Id { get; set; }
    }
}
