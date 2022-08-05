using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface In_MsgRepo<CLASS, ID>
    {
        List<CLASS> GetByEmails(ID email);
        bool DeleteByEmial(ID email);
    }
}
