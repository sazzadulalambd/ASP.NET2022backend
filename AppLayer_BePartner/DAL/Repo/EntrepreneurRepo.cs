using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    internal class EntrepreneurRepo : EM_IRepo<Entrepreneur, string>
    {
        bePartnerCentralDatabaseEntities db;

        public EntrepreneurRepo(bePartnerCentralDatabaseEntities db)
        {
            this.db = db;
        }

        public bool Create(Entrepreneur obj)
        {
            db.Entrepreneurs.Add(obj);
            var l = db.SaveChanges();
            if (l > 0)
            {
                return true;
            }
            return false;
        }

        public bool Delete(string email)
        {
            var Entrepreneur = Get(email);
            db.Entrepreneurs.Remove(Entrepreneur);
            var l = db.SaveChanges();
            if (l > 0)
            {
                return true;
            }
            return false;
        }

        public List<Entrepreneur> Get()
        {
            return db.Entrepreneurs.ToList();
        }

        public Entrepreneur Get(string email)
        {
            return db.Entrepreneurs.FirstOrDefault(s => s.En_Email.Equals(email));
        }

        public bool Update(Entrepreneur item)
        {
            var ems = (from I in db.Entrepreneurs where I.En_Email.Equals(item.En_Email) select I).FirstOrDefault();
            ems.En_Email = item.En_Email;
            ems.FirstName = item.FirstName;
            ems.LastName = item.LastName;
            ems.Gender = item.Gender;
            ems.Bob = item.Bob;
            ems.Address = item.Address;
            ems.Phone = item.Phone;
            ems.Nid = item.Nid;
            ems.Occupation = item.Occupation;
            ems.Img = item.Img;
            ems.Status = item.Status;
            try
            {
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
