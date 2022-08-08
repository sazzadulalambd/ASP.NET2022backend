using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    internal class NoticeRepo : AD_IRepo<Notice, int>
    {
        bePartnerCentralDatabaseEntities db;

        public NoticeRepo(bePartnerCentralDatabaseEntities db)
        {
            this.db = db;
        }

        public bool Create(Notice NOS)
        {
            db.Notices.Add(NOS);
            var l = db.SaveChanges();
            if (l > 0)
            {
                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {
            var Notice = Get(id);
            db.Notices.Remove(Notice);
            var l = db.SaveChanges();
            if (l > 0)
            {
                return true;
            }
            return false;
        }

        public List<Notice> Get()
        {
            return db.Notices.ToList();
        }

        public Notice Get(int id)
        {
            return db.Notices.FirstOrDefault(s => s.Notice_Id.Equals(id));
        }

        public bool Update(Notice NOS)
        {
            var nots = (from I in db.Notices where I.Notice_Id.Equals(NOS.Notice_Id) select I).FirstOrDefault();
            nots.Subject = NOS.Subject;
            nots.Description = NOS.Description;
            nots.Due_time = NOS.Due_time;
            nots.Status = NOS.Status;
            
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
