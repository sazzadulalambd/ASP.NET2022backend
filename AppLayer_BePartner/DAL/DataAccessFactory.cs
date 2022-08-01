using DAL.EF;
using DAL.Interfaces;
using DAL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        static bePartnerCentralDatabaseEntities db = new bePartnerCentralDatabaseEntities();

        //************** INVESTOR **************//

        public static In_IRepo<Investor,string> InvestorDataAccess()
        {
            return new InvestorRepo(db);
        }

        public static In_IRepo<Idea, string> IdeaDataAccess()
        {
            return new IdeaRepo(db);
        }

        public static In_IRepo<Message, string> MessageDataAccess()
        {
            return new MessageRepo(db);
        }

        public static In_IRepo<Report, string> ReportDataAccess()
        {
            return new ReportRepo(db);
        }

        //************** INVESTOR **************//



        //************** ADMIN **************//
            //code here
        //************** ADMIN **************//



        //************** EMPLOYEE **************//
            //code here
        //************** EMPLOYEE **************//
    }
}
