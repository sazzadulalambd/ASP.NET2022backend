using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    internal class InvestorRepo : In_IRepo<Investor, string>
    {
        bePartnerCentralDatabaseEntities db;

        public InvestorRepo(bePartnerCentralDatabaseEntities db)
        {
            this.db = db;
        }

        public bool Create(Investor obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(string id)
        {
            throw new NotImplementedException();
        }

        public List<Investor> Get()
        {
            throw new NotImplementedException();
        }

        public Investor Get(string id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Investor obj)
        {
            throw new NotImplementedException();
        }
    }
}
