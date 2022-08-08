using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    internal class EmployeeRepo : EM_IRepo<Employee, string>
    {
        bePartnerCentralDatabaseEntities db;

        public EmployeeRepo(bePartnerCentralDatabaseEntities db)
        {
            this.db = db;
        }

        public bool Create(Employee obj)
        {
            db.Employees.Add(obj);
            var l = db.SaveChanges();
            if (l > 0)
            {
                return true;
            }
            return false;
        }

        public bool Delete(string email)
        {
            var Employee = Get(email);
            db.Employees.Remove(Employee);
            var l = db.SaveChanges();
            if (l > 0)
            {
                return true;
            }
            return false;
        }

        public List<Employee> Get()
        {
            return db.Employees.ToList();
        }

        public Employee Get(string email)
        {
            return db.Employees.FirstOrDefault(s => s.Emp_Email.Equals(email));
        }

        public bool Update(Employee EM)
        {
            var ems = (from I in db.Employees where I.Emp_Email.Equals(EM.Emp_Email) select I).FirstOrDefault();
            ems.Emp_Email=EM.Emp_Email;
            ems.FirstName = EM.FirstName;
            ems.LastName = EM.LastName;
            ems.Dob = EM.Dob;
            ems.Address = EM.Address;
            ems.Phone = EM.Phone;
            ems.Security_key = EM.Security_key;
            ems.Gender = EM.Gender;
            ems.Nid = EM.Nid;
            ems.Password = EM.Password;
            ems.Img = EM.Img;
            ems.Status = EM.Status;
            try
            {
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
