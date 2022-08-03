using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    internal class MessageRepo : In_IRepo<Message, int>, In_MsgRepo<Message, string>
    {
        bePartnerCentralDatabaseEntities db;

        public MessageRepo(bePartnerCentralDatabaseEntities db)
        {
            this.db = db;
        }

        public bool Create(Message obj)
        {
            db.Messages.Add(obj);
            var l = db.SaveChanges();
            if(l > 0)
            {
                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {
            var message = Get(id);
            db.Messages.Remove(message);
            var l = db.SaveChanges();
            if (l > 0)
            {
                return true;
            }
            return false;
        }

        public bool DeleteByEmial(string email)
        {
            var msgs = (from I in db.Messages where I.Sender.Equals(email) || I.Receiver.Equals(email) select I).ToList();
            foreach (var msg in msgs)
            {
                db.Messages.Remove(msg);
            }
            var l = db.SaveChanges();
            if(l > 0)
            {
                return true;
            }
            return false;
        }

        public List<Message> Get()
        {
            return db.Messages.ToList();
        }

        public Message Get(int id)
        {
            var message = db.Messages.FirstOrDefault(s => s.MsgId == id);
            return message;
        }

        public List<Message> GetByEmail(string email)
        {
            var msgs = (from I in db.Messages where I.Sender.Equals(email) || I.Receiver.Equals(email) select I).ToList();
            return msgs;
        }

        public bool Update(Message obj)
        {
            var msg = db.Messages.FirstOrDefault(db => db.MsgId == obj.MsgId);
            msg.Status = obj.Status;
            var l = db.SaveChanges();
            if(l > 0)
            {
                return true;
            }
            return false;
        }

        
    }
}
