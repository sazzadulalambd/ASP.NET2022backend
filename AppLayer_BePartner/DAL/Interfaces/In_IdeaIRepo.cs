using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface In_IdeaIRepo<CLASS, ID>
    {
        List<CLASS> GetMyInvestment(ID email);
        CLASS GetByEnEmail(ID email);
    }
}
