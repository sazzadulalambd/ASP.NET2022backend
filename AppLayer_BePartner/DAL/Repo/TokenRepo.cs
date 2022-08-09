using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    internal class TokenRepo : In_IRepo<Token, string>
    {
        bePartnerCentralDatabaseEntities db;

        public TokenRepo(bePartnerCentralDatabaseEntities db)
        {
            this.db = db;
        }

        public bool Create(Token obj)
        {
            db.Tokens.Add(obj);
            var l= db.SaveChanges();
            if(l > 0)
            {
                return true;
            }
            return false;
        }

        public bool Delete(string id)
        {
            var token = db.Tokens.FirstOrDefault(t => t.Tkey.Equals(id));
            db.Tokens.Remove(token);
            var l= db.SaveChanges();
            if(l > 0)
            {
                return true;
            }
            return false;
        }

        public List<Token> Get()
        {
            return db.Tokens.ToList();
        }

        public Token Get(string id)
        {
            return db.Tokens.FirstOrDefault(t => t.Tkey.Equals(id));
        }

        public bool Update(Token obj)
        {
            var exst = db.Tokens.FirstOrDefault(x => x.Tkey.Equals(obj.Tkey));
            if (exst != null)
            {
                db.Entry(exst).CurrentValues.SetValues(obj);
                db.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
