using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    internal class ReportRepo : In_IRepo<Report, int>
    {
        bePartnerCentralDatabaseEntities db;

        public ReportRepo(bePartnerCentralDatabaseEntities db)
        {
            this.db = db;
        }

        public bool Create(Report obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Report> Get()
        {
            throw new NotImplementedException();
        }

        public Report Get(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Report obj)
        {
            throw new NotImplementedException();
        }
    }
}
