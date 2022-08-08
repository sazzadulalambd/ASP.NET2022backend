using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    internal class ReportRepo : AD_IRepo<Report, int> , Report_IRepo<Report, string>
    {
        bePartnerCentralDatabaseEntities db;

        public ReportRepo(bePartnerCentralDatabaseEntities db)
        {
            this.db = db;
        }

        public bool Create(Report ADS)
        {
            db.Reports.Add(ADS);
            var l = db.SaveChanges();
            if (l > 0)
            {
                return true;
            }
            return false;
        }

        public bool Delete(int ID)
        {
            var Report = Get(ID);
            db.Reports.Remove(Report);
            var l = db.SaveChanges();
            if (l > 0)
            {
                return true;
            }
            return false;
        }

        public List<Report> Get()
        {
            return db.Reports.ToList();
        }

        public Report Get(int ID)
        {
            return db.Reports.FirstOrDefault(s => s.ReportId.Equals(ID));
        }

        public bool Update(Report Ads)
        {
            var RE = (from I in db.Reports where I.ReportId.Equals(Ads.ReportId) select I).FirstOrDefault();
            if (RE != null)
            {
                RE.sender = Ads.sender;
                RE.Receiver = Ads.Receiver;
                RE.Title = Ads.Title;
                RE.Description = Ads.Description;
                RE.Report_Time = Ads.Report_Time;
                RE.Status = Ads.Status;
            }    
            
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

        public List<Report> sendByEmails(string SD_email)
        {
            
            var REPO = (from I in db.Reports where I.sender.Equals(SD_email) select I).ToList();
            return REPO;
            
        }

        public List<Report> recivedByEmails(string RC_email)
        {
            //return db.Reports.FirstOrDefault(s => s.Receiver.Equals(RC_email));
            var REPO = (from I in db.Reports where I.Receiver.Equals(RC_email) select I).ToList();
            return REPO;
        }
    }
}
