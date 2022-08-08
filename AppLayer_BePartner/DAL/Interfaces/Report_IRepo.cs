using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface Report_IRepo<CLASS, ID>
    {
        List<CLASS> sendByEmails(ID email);
        List<CLASS> recivedByEmails(ID email);

    }
}
