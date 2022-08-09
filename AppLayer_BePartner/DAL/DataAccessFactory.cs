
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

        public static In_IRepo<Idea, int> IdeaDataAccess()
        {
            return new IdeaRepo(db);
        }

        public static In_IdeaIRepo<Idea, string> IdeaDataByEmailAccess()
        {
            return new IdeaRepo(db);
        }

        public static In_IRepo<Message, int> MessageDataAccess()
        {
            return new MessageRepo(db);
        }

        public static In_MsgRepo<Message, string> MessageByEmailccess()
        {
            return new MessageRepo(db);
        }

        public static In_IRepo<Offer, int> OfferDataAccess()
        {
            return new OfferRepo(db);
        }

        public static In_OfferIRepo<Offer, string> OfferMoreDataAccess()
        {
            return new OfferRepo(db);
        }

        public static In_IRepo<User,int> GetUserDataAccess()
        {
            return new UserRepo(db);
        }

        public static IAuth<User> GetAuthDataAccess()
        {
            return new UserRepo(db);
        }

        public static In_IRepo<Token, string> GetTokenDataAccess()
        {
            return new TokenRepo(db);
        }
        //************** INVESTOR **************//



        //************** ADMIN **************//
        public static AD_IRepo<Admin, int> AdminDataAccess()
        {
            return new AdminRepo(db);
        }

        public static AD_IRepo<Report, int> ReportDataAccess()
        {
            return new ReportRepo(db);
        }

        public static Report_IRepo<Report, String> ReportgetSRDataAccess()
        {
            return new ReportRepo(db);
        }

        public static AD_IRepo<Notice, int> NoticeDataAccess()
        {
            return new NoticeRepo(db);
        }
        //************** ADMIN **************//



        //************** EMPLOYEE **************//
        public static EM_IRepo<Entrepreneur, string> EntrepreneurDataAccess()
        {
            return new EntrepreneurRepo(db);
        }
        public static EM_IRepo<Employee,string> EmployeeDataAccess()
        {
            return new EmployeeRepo(db);
        }
        //************** EMPLOYEE **************//
    }
}
