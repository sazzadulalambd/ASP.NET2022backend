using AutoMapper;
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
            db.Investors.Add(obj);
            var l = db.SaveChanges();
            if (l > 0)
            {
                return true;
            }
            return false;
        }

        public bool Delete(string email)
        {
            var investor = Get(email);
            db.Investors.Remove(investor);
            var l = db.SaveChanges();
            if (l > 0)
            {
                return true;
            }
            return false;
        }

        public List<Investor> Get()
        {
            return db.Investors.ToList();
        }

        public Investor Get(string email)
        {
            return db.Investors.FirstOrDefault(s => s.In_Email.Equals(email));
        }

        public bool Update(Investor In)
        {
            var Ed = (from I in db.Investors where I.In_Email.Equals(In.In_Email) select I).FirstOrDefault();
            Ed.FirstName = In.FirstName;
            Ed.LastName = In.LastName;
            Ed.Gender = In.Gender;
            Ed.Dob = In.Dob;
            Ed.Phone = In.Phone;
            Ed.Nid = In.Nid;
            Ed.Address = In.Address;
            //Ed.In_Email = In.In_Email;

            Ed.OrgName = In.OrgName;
            Ed.OrgEstablished = In.OrgEstablished;
            Ed.OrgLocation = In.OrgLocation;
            Ed.OrgEmail = In.OrgEmail;
            Ed.OrgPhone = In.OrgPhone;
            Ed.OrgLicense = In.OrgLicense;
            Ed.Tin = In.Tin;
            Ed.OrgSite = In.OrgSite;

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
