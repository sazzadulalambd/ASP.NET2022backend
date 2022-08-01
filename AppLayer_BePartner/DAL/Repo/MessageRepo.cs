using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    internal class MessageRepo : In_IRepo<Message, string>
    {
        bePartnerCentralDatabaseEntities db;

        public MessageRepo(bePartnerCentralDatabaseEntities db)
        {
            this.db = db;
        }

        public bool Create(Message obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(string id)
        {
            throw new NotImplementedException();
        }

        public List<Message> Get()
        {
            throw new NotImplementedException();
        }

        public Message Get(string id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Message obj)
        {
            throw new NotImplementedException();
        }
    }
}
