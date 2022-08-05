using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    internal class UserRepo : In_IRepo<User, int>, IAuth<User>
    {
        bePartnerCentralDatabaseEntities db;

        public UserRepo(bePartnerCentralDatabaseEntities db)
        {
            this.db = db;
        }

        public User Authenticate(string email, string password)
        {
            return db.Users.FirstOrDefault(u => u.Email.Equals(email) && u.Password.Equals(password));
        }

        public bool Create(User obj)
        {
            db.Users.Add(obj);
            var l = db.SaveChanges();
            if (l > 0)
            {
                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {
            var offer = Get(id);
            db.Users.Remove(offer);
            var l = db.SaveChanges();
            if (l > 0)
            {
                return true;
            }
            return false;
        }

        public List<User> Get()
        {
            return db.Users.ToList();
        }

        public User Get(int id)
        {
            return db.Users.FirstOrDefault(o => o.Id == id);
        }

        public bool Update(User obj)
        {
           throw new NotImplementedException();
        }
    }
}
