using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    internal class EntrepreneurRepo : In_IRepo<Entrepreneur, string>
    {
        bePartnerCentralDatabaseEntities db;

        public EntrepreneurRepo(bePartnerCentralDatabaseEntities db)
        {
            this.db = db;
        }

        public bool Create(Entrepreneur obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(string id)
        {
            throw new NotImplementedException();
        }

        public List<Entrepreneur> Get()
        {
            throw new NotImplementedException();
        }

        public Entrepreneur Get(string email)
        {
            return db.Entrepreneurs.FirstOrDefault(s => s.En_Email.Equals(email));
        }

        public bool Update(Entrepreneur obj)
        {
            throw new NotImplementedException();
        }
    }
}
