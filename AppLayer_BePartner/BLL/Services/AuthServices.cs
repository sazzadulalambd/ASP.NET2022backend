using BLL.Entities;
using BLL.Security;
using DAL;
using DAL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class AuthServices
    {
        public static TokenModel Authenticate(string email, string pass)
        {
            var user = DataAccessFactory.GetAuthDataAccess().Authenticate(email, pass);
            TokenModel t = new TokenModel();
            if(user != null)
            {
                var token = new Token();
                token.User_Id = user.Id;
                token.CreatedAt = DateTime.Now;
                token.Tkey = RandomToken.RandomString();
                if (DataAccessFactory.GetTokenDataAccess().Create(token))
                {
                    t.User_Id = user.Id;
                    t.CreatedAt = DateTime.Now;
                    t.Tkey = token.Tkey;
                }
                return t;
            }
            return null;
        }

        public static bool TokenValidity(string token)
        {
            var tk = DataAccessFactory.GetTokenDataAccess().Get(token);
            if (tk != null && tk.ExpiredAt == null)
            {
                return true;
            }
            return false;

        }

        public static bool Logout(TokenModel tk)
        {
            var d_tk = DataAccessFactory.GetTokenDataAccess().Get(tk.Tkey);
            d_tk.ExpiredAt = DateTime.Now;
            return DataAccessFactory.GetTokenDataAccess().Update(d_tk);

        }
    }
}
