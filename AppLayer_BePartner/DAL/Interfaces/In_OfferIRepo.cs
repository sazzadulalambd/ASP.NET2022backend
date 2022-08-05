using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface In_OfferIRepo<CLASS, ID>
    {
        List<CLASS> MySentOffer(ID email);
        bool DeleteByInEmail(ID email);
        bool DeleteByEnEmail(ID email);
    }
}
