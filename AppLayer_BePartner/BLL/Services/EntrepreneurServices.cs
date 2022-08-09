using Entity;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class EntrepreneurServices
    {
        public static EntrepreneurModel Get(string email)
        {
            var item = DataAccessFactory.EntrepreneurDataAccess().Get(email);
            if(item != null)
            {
                var En = new EntrepreneurModel()
                {
                    En_Email = email,
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                    Gender = item.Gender,
                    Bob = item.Bob,
                    Address = item.Address,
                    Phone = item.Phone,
                    Nid = item.Nid,
                    Occupation = item.Occupation,
                    Img = item.Img,
                    Status = item.Status
                };
                return En;
            }
            return null;
        }
    }
}
