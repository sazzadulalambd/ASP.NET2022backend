using BLL.Entities;
using DAL;
using DAL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class InvestorService
    {
        public static List<InvestorModel> Get()
        {
            var data = DataAccessFactory.InvestorDataAccess().Get();
            var investors = new List<InvestorModel>();

            foreach(var item in data)
            {
                InvestorModel In = new InvestorModel()
                {
                    In_Email = item.In_Email,
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                    Dob = item.Dob,
                    Gender = item.Gender,
                    Address = item.Address,
                    Phone = item.Phone,
                    Nid = item.Nid,

                    OrgName = item.OrgName,
                    OrgEstablished = item.OrgEstablished,
                    OrgLocation = item.OrgLocation,
                    OrgEmail = item.OrgEmail,
                    OrgPhone = item.OrgPhone,
                    OrgLicense = item.OrgLicense,
                    Tin = item.Tin,
                    OrgSite = item.OrgSite,

                    Password = PassSecurity.DecryptString(item.Password),
                    
                    Status = item.Status,
                    EmailValidation = item.EmailValidation,
                    Img = item.Img

                };
                investors.Add(In);
                
            }

            return investors;
        }

        public static InvestorModel Get(string email)
        {
            //email = email + ".com";
            var item = DataAccessFactory.InvestorDataAccess().Get(email);
            if(item != null)
            {
                InvestorModel In = new InvestorModel()
                {
                    In_Email = item.In_Email,
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                    Dob = item.Dob,
                    Gender = item.Gender,
                    Address = item.Address,
                    Phone = item.Phone,
                    Nid = item.Nid,

                    OrgName = item.OrgName,
                    OrgEstablished = item.OrgEstablished,
                    OrgLocation = item.OrgLocation,
                    OrgEmail = item.OrgEmail,
                    OrgPhone = item.OrgPhone,
                    OrgLicense = item.OrgLicense,
                    Tin = item.Tin,
                    OrgSite = item.OrgSite,

                    Password = PassSecurity.DecryptString(item.Password),

                    Status = item.Status,
                    EmailValidation = item.EmailValidation,
                    Img = item.Img

                };
                return In;
            }
            return null;
        }

        public static bool Create(InvestorModel item)
        {
            Investor In = new Investor()
            {
                In_Email = item.In_Email,
                FirstName = item.FirstName,
                LastName = item.LastName,
                Dob = item.Dob,
                Gender = item.Gender,
                Address = item.Address,
                Phone = item.Phone,
                Nid = item.Nid,

                OrgName = item.OrgName,
                OrgEstablished = item.OrgEstablished,
                OrgLocation = item.OrgLocation,
                OrgEmail = item.OrgEmail,
                OrgPhone = item.OrgPhone,
                OrgLicense = item.OrgLicense,
                Tin = item.Tin,
                OrgSite = item.OrgSite,

                Password = PassSecurity.EnryptString(item.Password),

                Status = item.Status,
                EmailValidation = item.EmailValidation,
                Img = item.Img

            };
            return DataAccessFactory.InvestorDataAccess().Create(In);
        }

        public static bool Update(InvestorModel item)
        {
            Investor In = new Investor()
            {
                In_Email = item.In_Email,
                FirstName = item.FirstName,
                LastName = item.LastName,
                Dob = item.Dob,
                Gender = item.Gender,
                Address = item.Address,
                Phone = item.Phone,
                Nid = item.Nid,

                OrgName = item.OrgName,
                OrgEstablished = item.OrgEstablished,
                OrgLocation = item.OrgLocation,
                OrgEmail = item.OrgEmail,
                OrgPhone = item.OrgPhone,
                OrgLicense = item.OrgLicense,
                Tin = item.Tin,
                OrgSite = item.OrgSite,

                Password = PassSecurity.EnryptString(item.Password),

                Status = item.Status,
                EmailValidation = item.EmailValidation,
                Img = item.Img

            };
            return DataAccessFactory.InvestorDataAccess().Update(In);
        }

        public static bool Delete(string email)
        {
            //email = email + ".com";
            return DataAccessFactory.InvestorDataAccess().Delete(email);
        }

    }
}
