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
    public class ReportService
    {
        public static List<ReportModel> Get()
        {
            var data = DataAccessFactory.ReportDataAccess().Get();
            var Reports = new List<ReportModel>();

            foreach (var item in data)
            {
                ReportModel rep = new ReportModel()
                {

                    ReportId = item.ReportId,
                    sender = item.sender,
                    Receiver = item.Receiver,
                    Title = item.Title,
                    Description = item.Description,
                    Report_Time = item.Report_Time,
                    Status = item.Status

                };
                Reports.Add(rep);

            }

            return Reports;
        }

        public static ReportModel sendByEmails(string email)
        {
            var data = DataAccessFactory.ReportgetSRDataAccess().sendByEmails(email);
            var Reports = new List<ReportModel>();

            foreach (var item in data)
            {
                ReportModel rep = new ReportModel()
                {
                    ReportId = item.ReportId,
                    sender = item.sender,
                    Receiver = item.Receiver,
                    Title = item.Title,
                    Description = item.Description,
                    Report_Time = item.Report_Time,
                    Status = item.Status
                };
                Reports.Add(rep);
            }
            return null;
        }

        public static ReportModel recivedByEmails(string email)
        {
            var data = DataAccessFactory.ReportgetSRDataAccess().recivedByEmails(email);
            var Reports = new List<ReportModel>();

            foreach (var item in data)
            {
                ReportModel rep = new ReportModel()
                {
                    ReportId = item.ReportId,
                    sender = item.sender,
                    Receiver = item.Receiver,
                    Title = item.Title,
                    Description = item.Description,
                    Report_Time = item.Report_Time,
                    Status = item.Status
                };
                Reports.Add(rep);
            }
            return null;
        }

        public static bool Create(ReportModel item)
        {
            Report AD = new Report()
            {

                sender = item.sender,
                Receiver = item.Receiver,
                Title = item.Title,
                Description = item.Description,
                Report_Time = item.Report_Time,
                Status = item.Status

            };
            return DataAccessFactory.ReportDataAccess().Create(AD);
        }

        public static bool Update(ReportModel item)
        {

            Report AD = new Report()
            {

                sender = item.sender,
                Receiver = item.Receiver,
                Title = item.Title,
                Description = item.Description,
                Report_Time = item.Report_Time,
                Status = item.Status

            };
            return DataAccessFactory.ReportDataAccess().Update(AD);

        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.ReportDataAccess().Delete(id);
        }
    }
}
