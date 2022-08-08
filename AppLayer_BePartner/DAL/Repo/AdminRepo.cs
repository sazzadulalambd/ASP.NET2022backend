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
    internal class AdminRepo : AD_IRepo<Admin, int>
    {
        bePartnerCentralDatabaseEntities db;

        public AdminRepo(bePartnerCentralDatabaseEntities db)
        {
            this.db = db;
        }

        public bool Create(Admin ADS)
        {
            db.Admins.Add(ADS);
            var l = db.SaveChanges();
            if (l > 0)
            {
                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {
            var Admin = Get(id);
            db.Admins.Remove(Admin);
            var l = db.SaveChanges();
            if (l > 0)
            {
                return true;
            }
            return false;
        }

        public List<Admin> Get()
        {
            return db.Admins.ToList();
        }

        public Admin Get(int id)
        {
            return db.Admins.FirstOrDefault(s => s.ID.Equals(id));
        }

        public bool Update(Admin Ads)
        {
            var AD = (from I in db.Admins where I.Ad_Email.Equals(Ads.Ad_Email) select I).FirstOrDefault();

            AD.Ad_Email = Ads.Ad_Email;
            AD .FirstName = Ads.FirstName;
            AD.LastName = Ads.LastName;
            AD.Dob = Ads.Dob;
            AD.Address = Ads.Address;
            AD.Phone = Ads.Phone;
            AD.Security_key = Ads.Security_key;
            AD.Gender = Ads.Gender;
            AD.Nid = Ads.Nid;
            AD.Password = Ads.Password;
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
