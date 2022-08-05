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
    public class MessageServices
    {
        public static List<MessageModel> Get()
        {
            var data = DataAccessFactory.MessageDataAccess().Get();
            var messages = new List<MessageModel>();

            foreach(var item in data)
            {
                MessageModel Im = new MessageModel()
                {
                    MsgId = item.MsgId,
                    Sender = item.Sender,
                    Receiver = item.Receiver,
                    Message = item.Message1,
                    Status = item.Status,
                    Ttime = item.Time
                };
                messages.Add(Im);
            }
            return messages;
        }

        public static MessageModel Get(int id)
        {
            var item = DataAccessFactory.MessageDataAccess().Get(id);
            if(item != null)
            {
                MessageModel Im = new MessageModel()
                {
                    MsgId = item.MsgId,
                    Sender = item.Sender,
                    Receiver = item.Receiver,
                    Message = item.Message1,
                    Status = item.Status,
                    Ttime = item.Time
                };
                return Im;
            }
            return null;
        }

        public static bool Create(MessageModel item)
        {
            Message Im = new Message()
            {
                MsgId = item.MsgId,
                Sender = item.Sender,
                Receiver = item.Receiver,
                Message1 = item.Message,
                Status = item.Status,
                Time = item.Ttime
            };
            return DataAccessFactory.MessageDataAccess().Create(Im);
        }

        public static bool Update(MessageModel item)
        {
            Message Im = new Message()
            {
                MsgId = item.MsgId,
                Sender = item.Sender,
                Receiver = item.Receiver,
                Message1 = item.Message,
                Status = item.Status,
                Time = item.Ttime
            };
            return DataAccessFactory.MessageDataAccess().Update(Im);
        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.MessageDataAccess().Delete(id);
        }

        public static List<InvestorMessageModel> GetByEmail(string email)
        {
            var data = DataAccessFactory.MessageByEmailccess().GetByEmails(email);
            var messages = new List<InvestorMessageModel>();

            foreach (var item in data)
            {
                InvestorMessageModel Im = new InvestorMessageModel()
                {
                    MsgId = item.MsgId,
                    Sender = item.Sender,
                    Receiver = item.Receiver,
                    Message = item.Message1,
                    Status = item.Status,
                    Ttime = item.Time
                };

                if (item.Sender.Equals(email))
                {
                    var R = EntrepreneurServices.Get(item.Receiver);

                    Im.ReceiverName = R.FirstName + " " + R.LastName;
                    Im.ReceiverOccupation = R.Occupation;
                    Im.ReceiverImg = R.Img;
                    Im.ReceiverPhone = R.Phone;
                    Im.ReceiverCompany = IdeaServices.GetByEnEmail(item.Receiver).Company_Name;

                    //Im.SenderName = null;
                    //Im.SenderOccupation = null;
                    //Im.SenderImg = null;
                    //Im.SenderCompany = null;
                    //Im.SenderPhone = null;
                }
                else
                {
                    var R = EntrepreneurServices.Get(item.Sender);

                    Im.SenderName = R.FirstName + " " + R.LastName;
                    Im.SenderOccupation = R.Occupation;
                    Im.SenderImg = R.Img;
                    Im.SenderPhone = R.Phone;
                    Im.SenderCompany = IdeaServices.GetByEnEmail(item.Sender).Company_Name;

                    //Im.ReceiverName = null;
                    //Im.ReceiverOccupation = null;
                    //Im.ReceiverImg = null;
                    //Im.ReceiverCompany = null;
                    //Im.ReceiverPhone= null;
                }
                messages.Add(Im);
            }

            return messages;
        }

        public static bool DeleteByEmail(string email)
        {
            return DataAccessFactory.MessageByEmailccess().DeleteByEmial(email);
        }
    }
}
