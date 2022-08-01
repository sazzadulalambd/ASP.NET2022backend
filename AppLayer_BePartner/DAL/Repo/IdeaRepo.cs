using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    internal class IdeaRepo : In_IRepo<Idea, string>
    {
        bePartnerCentralDatabaseEntities db;

        public IdeaRepo(bePartnerCentralDatabaseEntities db)
        {
            this.db = db;
        }

        public bool Create(Idea obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(string id)
        {
            throw new NotImplementedException();
        }

        public List<Idea> Get()
        {
            throw new NotImplementedException();
        }

        public Idea Get(string id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Idea obj)
        {
            throw new NotImplementedException();
        }
    }
}
