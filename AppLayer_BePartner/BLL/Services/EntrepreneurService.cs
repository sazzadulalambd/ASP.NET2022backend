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
    public class EntrepreneurService
    {
        public static List<EntrepreneurModel> Get()
        {
            var data = DataAccessFactory.EntrepreneurDataAccess().Get();
            var Entrepreneurs = new List<EntrepreneurModel>();

            foreach (var item in data)
            {
                EntrepreneurModel EnM = new EntrepreneurModel()
                {
                    En_Email = item.En_Email,
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
                Entrepreneurs.Add(EnM);

            }

            return Entrepreneurs;
        }

        public static EntrepreneurModel Get(string email)
        {

            var item = DataAccessFactory.EntrepreneurDataAccess().Get(email);
            if (item != null)
            {
                EntrepreneurModel EnM = new EntrepreneurModel()
                {
                    En_Email = item.En_Email,
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
                return EnM;
            }
            return null;
        }

        public static bool Create(EntrepreneurModel item)
        {
            Entrepreneur EnM = new Entrepreneur()
            {
                En_Email = item.En_Email,
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
            return DataAccessFactory.EntrepreneurDataAccess().Create(EnM);
        }

        public static bool Update(EntrepreneurModel item)
        {
            Entrepreneur EnM = new Entrepreneur()
            {
                En_Email = item.En_Email,
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
            return DataAccessFactory.EntrepreneurDataAccess().Update(EnM);
        }

        public static bool Delete(string email)
        {

            return DataAccessFactory.EntrepreneurDataAccess().Delete(email);
        }
    }
}
