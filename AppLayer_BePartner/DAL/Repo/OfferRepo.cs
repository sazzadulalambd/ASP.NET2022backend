using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    internal class OfferRepo : In_IRepo<Offer, int>
    {
        bePartnerCentralDatabaseEntities db;

        public OfferRepo(bePartnerCentralDatabaseEntities db)
        {
            this.db = db;
        }
        public bool Create(Offer obj)
        {
            db.Offers.Add(obj);
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
            db.Offers.Remove(offer);
            var l = db.SaveChanges();
            if (l > 0)
            {
                return true;
            }
            return false;
        }

        public List<Offer> Get()
        {
            return db.Offers.ToList();
        }

        public Offer Get(int id)
        {
            return db.Offers.FirstOrDefault(o => o.Id == id);
        }

        public bool Update(Offer obj)
        {
            var offer = db.Offers.FirstOrDefault(o => o.Id == obj.Id);

            offer.En_Email = obj.En_Email;
            offer.In_Email = obj.In_Email;
            offer.Offered_Amount = obj.Offered_Amount;
            offer.Offered_Share = obj.Offered_Share;
            offer.Title = obj.Title;
            offer.Description = obj.Description;
            offer.Ideas_Id = obj.Ideas_Id;

            var l = db.SaveChanges();

            if(l > 0)
            {
                return true;
            }
            return false;
        }
    }
}
