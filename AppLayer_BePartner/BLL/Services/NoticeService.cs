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
    public class NoticeService
    {
        public static List<NoticeModel> Get()
        {
            var data = DataAccessFactory.NoticeDataAccess().Get();
            var Notices = new List<NoticeModel>();

            foreach (var item in data)
            {
                NoticeModel AD = new NoticeModel()
                {
                    Notice_Id = item.Notice_Id,
                    Subject = item.Subject,
                    Description = item.Description,
                    Issue_time = item.Issue_time,
                    Due_time = item.Due_time,
                    Status = item.Status
                };
                Notices.Add(AD);

            }

            return Notices;
        }

        public static NoticeModel Get(int id)
        {
            var item = DataAccessFactory.NoticeDataAccess().Get(id);
            if (item != null)
            {
                NoticeModel AD = new NoticeModel()
                {
                    Notice_Id = item.Notice_Id,
                    Subject = item.Subject,
                    Description = item.Description,
                    Issue_time = item.Issue_time,
                    Due_time = item.Due_time,
                    Status = item.Status
                };
                return AD;
            }
            return null;
        }

        public static bool Create(NoticeModel item)
        {
            Notice AD = new Notice()
            {
                Notice_Id = item.Notice_Id,
                Subject = item.Subject,
                Description = item.Description,
                Issue_time = item.Issue_time,
                Due_time = item.Due_time,
                Status = item.Status

            };
            return DataAccessFactory.NoticeDataAccess().Create(AD);
        }

        public static bool Update(NoticeModel item)
        {

            Notice AD = new Notice()
            {
                Notice_Id = item.Notice_Id,
                Subject = item.Subject,
                Description = item.Description,
                Issue_time = item.Issue_time,
                Due_time = item.Due_time,
                Status = item.Status

            };
            return DataAccessFactory.NoticeDataAccess().Update(AD);

        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.NoticeDataAccess().Delete(id);
        }
    }
}
