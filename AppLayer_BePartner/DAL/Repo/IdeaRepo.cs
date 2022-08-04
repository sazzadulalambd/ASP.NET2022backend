using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    internal class IdeaRepo : In_IRepo<Idea, int>, In_IdeaIRepo<Idea, string>
    {
        bePartnerCentralDatabaseEntities db;

        public IdeaRepo(bePartnerCentralDatabaseEntities db)
        {
            this.db = db;
        }

        public bool Create(Idea obj)
        {
            db.Ideas.Add(obj);
            var l = db.SaveChanges();
            if(l > 0)
            {
                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {
            var idea = Get(id);
            db.Ideas.Remove(idea);
            var l = db.SaveChanges();
            if( l > 0)
            {
                return true;
            }
            return false;
        }

        public List<Idea> Get()
        {
            var data = (from I in db.Ideas where !I.Status.Equals("Confirmed") select I).ToList();
            return data;
        }

        public Idea Get(int id)
        {
            return db.Ideas.FirstOrDefault(s => s.PostId == id);
        }

        public List<Idea> GetMyInvestment(string email)
        {
            var En = (from I in db.Ideas where I.In_Asp_Email.Equals(email) select I).ToList();
            return En;
        }

        public bool Update(Idea obj)
        {
            var idea = db.Ideas.FirstOrDefault(s => s.Company_Name.Equals(obj.Company_Name));

            idea.Status = obj.Status;
            idea.In_Asp_Email = obj.In_Asp_Email;
            idea.Asking_Amount = obj.Asking_Amount;
            idea.Asking_Share = obj.Asking_Share;
            var l = db.SaveChanges();
            if (l > 0)
            {
                return true;
            }
            return false;
        }
    }
}
