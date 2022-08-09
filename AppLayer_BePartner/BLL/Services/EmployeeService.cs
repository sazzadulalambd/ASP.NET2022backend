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
    public class EmployeeService
    {
        public static List<EmployeeModel> Get()
        {
            var data = DataAccessFactory.EmployeeDataAccess().Get();
            var Employees = new List<EmployeeModel>();

            foreach (var EM in data)
            {
                EmployeeModel EEM = new EmployeeModel()
                {
                    Emp_Email = EM.Emp_Email,
                    FirstName = EM.FirstName,
                    LastName = EM.LastName,
                    Dob = EM.Dob,
                    Address = EM.Address,
                    Phone = EM.Phone,
                    Security_key = EM.Security_key,
                    Gender = EM.Gender,
                    Nid = EM.Nid,
                    Password = EM.Password,
                    Img = EM.Img,
                    Status = EM.Status

                };
                Employees.Add(EEM);

            }

            return Employees;
        }

        public static EmployeeModel Get(string email)
        {

            var EM = DataAccessFactory.EmployeeDataAccess().Get(email);
            if (EM != null)
            {
                EmployeeModel EEM = new EmployeeModel()
                {
                    Emp_Email = EM.Emp_Email,
                    FirstName = EM.FirstName,
                    LastName = EM.LastName,
                    Dob = EM.Dob,
                    Address = EM.Address,
                    Phone = EM.Phone,
                    Security_key = EM.Security_key,
                    Gender = EM.Gender,
                    Nid = EM.Nid,
                    Password = EM.Password,
                    Img = EM.Img,
                    Status = EM.Status

                };
                return EEM;
            }
            return null;
        }

        public static bool Create(EmployeeModel EM)
        {
            Employee EEM = new Employee()
            {
                Emp_Email = EM.Emp_Email,
                FirstName = EM.FirstName,
                LastName = EM.LastName,
                Dob = EM.Dob,
                Address = EM.Address,
                Phone = EM.Phone,
                Security_key = EM.Security_key,
                Gender = EM.Gender,
                Nid = EM.Nid,
                Password = EM.Password,
                Img = EM.Img,
                Status = EM.Status

            };
            return DataAccessFactory.EmployeeDataAccess().Create(EEM);
        }

        public static bool Update(EmployeeModel EM)
        {
            Employee EEM = new Employee()
            {
                Emp_Email = EM.Emp_Email,
                FirstName = EM.FirstName,
                LastName = EM.LastName,
                Dob = EM.Dob,
                Address = EM.Address,
                Phone = EM.Phone,
                Security_key = EM.Security_key,
                Gender = EM.Gender,
                Nid = EM.Nid,
                Password = EM.Password,
                Img = EM.Img,
                Status = EM.Status

            };
            return DataAccessFactory.EmployeeDataAccess().Update(EEM);
        }

        public static bool Delete(string email)
        {

            return DataAccessFactory.EmployeeDataAccess().Delete(email);
        }
    }
}
