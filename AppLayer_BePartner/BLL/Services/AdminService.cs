using DAL;
using DAL.EF;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class AdminService
    {
        public static List<AdminModel> Get()
        {
            var data = DataAccessFactory.AdminDataAccess().Get();
            var Admins = new List<AdminModel>();

            foreach (var item in data)
            {
                AdminModel AD = new AdminModel()
                {
                    ID = item.ID,
                    Ad_Email = item.Ad_Email,
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                    Dob = item.Dob,
                    Address = item.Address,
                    Phone = item.Phone,
                    Security_key = item.Security_key,
                    Gender = item.Gender,
                    Nid = item.Nid,
                    //Password = PassSecurity.DecryptString(item.Password),
                    Password = item.Password,
                    Img = item.Img

                };
                Admins.Add(AD);

            }

            return Admins;
        }

        public static AdminModel Get(int id)
        {
            var item = DataAccessFactory.AdminDataAccess().Get(id);
            if (item != null)
            {
                AdminModel AD = new AdminModel()
                {
                    ID=item.ID,
                    Ad_Email = item.Ad_Email,
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                    Dob = item.Dob,
                    Address = item.Address,
                    Phone = item.Phone,
                    Security_key = item.Security_key,
                    Gender = item.Gender,
                    Nid = item.Nid,
                    //Password = PassSecurity.DecryptString(item.Password),
                    Password = item.Password,
                    Img = item.Img
                };
                return AD;
            }
            return null;
        }

        public static bool Create(AdminModel item)
        {
            Admin AD = new Admin()
            {
                Ad_Email = item.Ad_Email,
                FirstName = item.FirstName,
                LastName = item.LastName,
                Dob = item.Dob,
                Address = item.Address,
                Phone = item.Phone,
                Security_key = item.Security_key,
                Gender = item.Gender,
                Nid = item.Nid,
                //Password = PassSecurity.DecryptString(item.Password),
                Password = item.Password,
                Img = item.Img

            };
            return DataAccessFactory.AdminDataAccess().Create(AD);
        }

        public static bool Update(AdminModel item)
        {

            Admin AD = new Admin()
            {
                Ad_Email = item.Ad_Email,
                FirstName = item.FirstName,
                LastName = item.LastName,
                Dob = item.Dob,
                Address = item.Address,
                Phone = item.Phone,
                Security_key = item.Security_key,
                Gender = item.Gender,
                Nid = item.Nid,
                //Password = PassSecurity.DecryptString(item.Password),
                Password = item.Password,
                Img = item.Img

            };
            return DataAccessFactory.AdminDataAccess().Update(AD);
           
        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.AdminDataAccess().Delete(id);
        }
    }
}
