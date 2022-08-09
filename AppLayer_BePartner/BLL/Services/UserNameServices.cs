using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class UserNameServices
    {
        public static string Get(string auth)
        {
            return DataAccessFactory.GetUserDataAccess().Get(DataAccessFactory.GetTokenDataAccess().Get(auth).User_Id).Email;
        }
    }
}
