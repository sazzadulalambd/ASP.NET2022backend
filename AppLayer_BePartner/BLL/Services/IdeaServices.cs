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
    public class IdeaServices
    {
        public static List<IdeaModel> Get()
        {
            var data = DataAccessFactory.IdeaDataAccess().Get();
            var ideas = new List<IdeaModel>();
            
            foreach (var item in data)
            {
                IdeaModel model = new IdeaModel()
                {
                    PostId = item.PostId,
                    En_Post_Email = item.En_Post_Email,
                    In_Asp_Email = item.In_Asp_Email,
                    Company_Name = item.Company_Name,
                    Moto = item.Moto,
                    Description = item.Description,
                    Post_Time = item.Post_Time,
                    Asking_Amount = item.Asking_Amount,
                    Asking_Share = item.Asking_Share,
                    Status = item.Status,
                    Message = item.Message,
                    Offer_Amount = item.Offer_Amount,
                    Offer_Share = item.Offer_Share,
                    Img = item.Img,
                    Category = item.Category,
                    Total_Profit = item.Total_Profit,
                    Last_Month_profit = item.Last_Month_profit,
                    Last_Year_Profit = item.Last_Year_Profit,
                    Valuation = item.Valuation,
                    Feature1_Title = item.Feature1_Title,
                    Feature1_Des = item.Feature1_Des,
                    Feature2_Title = item.Feature2_Title,
                    Feature2_Des = item.Feature2_Des,
                    Feature3_Title = item.Feature3_Title,
                    Feature3_Des = item.Feature3_Des,
                    Feature4_Title = item.Feature4_Title,
                    Feature4_Des = item.Feature4_Des,

                    En_Name = EntrepreneurService.Get(item.En_Post_Email).FirstName + " " + EntrepreneurService.Get(item.En_Post_Email).LastName
                };
                ideas.Add(model);
            }
            return ideas;
        }

        public static IdeaModel Get(int Id)
        {
            var item = DataAccessFactory.IdeaDataAccess().Get(Id);
            if(item != null)
            {
                IdeaModel model = new IdeaModel()
                {
                    PostId = item.PostId,
                    En_Post_Email = item.En_Post_Email,
                    In_Asp_Email = item.In_Asp_Email,
                    Company_Name = item.Company_Name,
                    Moto = item.Moto,
                    Description = item.Description,
                    Post_Time = item.Post_Time,
                    Asking_Amount = item.Asking_Amount,
                    Asking_Share = item.Asking_Share,
                    Status = item.Status,
                    Message = item.Message,
                    Offer_Amount = item.Offer_Amount,
                    Offer_Share = item.Offer_Share,
                    Img = item.Img,
                    Category = item.Category,
                    Total_Profit = item.Total_Profit,
                    Last_Month_profit = item.Last_Month_profit,
                    Last_Year_Profit = item.Last_Year_Profit,
                    Valuation = item.Valuation,
                    Feature1_Title = item.Feature1_Title,
                    Feature1_Des = item.Feature1_Des,
                    Feature2_Title = item.Feature2_Title,
                    Feature2_Des = item.Feature2_Des,
                    Feature3_Title = item.Feature3_Title,
                    Feature3_Des = item.Feature3_Des,
                    Feature4_Title = item.Feature4_Title,
                    Feature4_Des = item.Feature4_Des,

                    En_Name = EntrepreneurService.Get(item.En_Post_Email).FirstName + " " + EntrepreneurService.Get(item.En_Post_Email).LastName
                };
                return model;
            }
            
            return null;
        }

        public static bool Create(IdeaModel item)
        {
            Idea model = new Idea()
            {
                PostId = item.PostId,
                En_Post_Email = item.En_Post_Email,
                In_Asp_Email = item.In_Asp_Email,
                Company_Name = item.Company_Name,
                Moto = item.Moto,
                Description = item.Description,
                Post_Time = item.Post_Time,
                Asking_Amount = item.Asking_Amount,
                Asking_Share = item.Asking_Share,
                Status = item.Status,
                Message = item.Message,
                Offer_Amount = item.Offer_Amount,
                Offer_Share = item.Offer_Share,
                Img = item.Img,
                Category = item.Category,
                Total_Profit = item.Total_Profit,
                Last_Month_profit = item.Last_Month_profit,
                Last_Year_Profit = item.Last_Year_Profit,
                Valuation = item.Valuation,
                Feature1_Title = item.Feature1_Title,
                Feature1_Des = item.Feature1_Des,
                Feature2_Title = item.Feature2_Title,
                Feature2_Des = item.Feature2_Des,
                Feature3_Title = item.Feature3_Title,
                Feature3_Des = item.Feature3_Des,
                Feature4_Title = item.Feature4_Title,
                Feature4_Des = item.Feature4_Des
            };
            return DataAccessFactory.IdeaDataAccess().Create(model);
        }

        public static bool Update(IdeaModel item)
        {
            Idea model = new Idea()
            {
                PostId = item.PostId,
                En_Post_Email = item.En_Post_Email,
                In_Asp_Email = item.In_Asp_Email,
                Company_Name = item.Company_Name,
                Moto = item.Moto,
                Description = item.Description,
                Post_Time = item.Post_Time,
                Asking_Amount = item.Asking_Amount,
                Asking_Share = item.Asking_Share,
                Status = item.Status,
                Message = item.Message,
                Offer_Amount = item.Offer_Amount,
                Offer_Share = item.Offer_Share,
                Img = item.Img,
                Category = item.Category,
                Total_Profit = item.Total_Profit,
                Last_Month_profit = item.Last_Month_profit,
                Last_Year_Profit = item.Last_Year_Profit,
                Valuation = item.Valuation,
                Feature1_Title = item.Feature1_Title,
                Feature1_Des = item.Feature1_Des,
                Feature2_Title = item.Feature2_Title,
                Feature2_Des = item.Feature2_Des,
                Feature3_Title = item.Feature3_Title,
                Feature3_Des = item.Feature3_Des,
                Feature4_Title = item.Feature4_Title,
                Feature4_Des = item.Feature4_Des
            };
            return DataAccessFactory.IdeaDataAccess().Update(model);
        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.IdeaDataAccess().Delete(id);
        }

        public static List<IdeaModel> MyInvestment(string email)
        {
            var data = DataAccessFactory.IdeaDataByEmailAccess().GetMyInvestment(email);
            var ideas = new List<IdeaModel>();

            foreach(var item in data)
            {
                IdeaModel model = new IdeaModel()
                {
                    PostId = item.PostId,
                    En_Post_Email = item.En_Post_Email,
                    In_Asp_Email = item.In_Asp_Email,
                    Company_Name = item.Company_Name,
                    Moto = item.Moto,
                    Description = item.Description,
                    Post_Time = item.Post_Time,
                    Asking_Amount = item.Asking_Amount,
                    Asking_Share = item.Asking_Share,
                    Status = item.Status,
                    Message = item.Message,
                    Offer_Amount = item.Offer_Amount,
                    Offer_Share = item.Offer_Share,
                    Img = item.Img,
                    Category = item.Category,
                    Total_Profit = item.Total_Profit,
                    Last_Month_profit = item.Last_Month_profit,
                    Last_Year_Profit = item.Last_Year_Profit,
                    Valuation = item.Valuation,
                    Feature1_Title = item.Feature1_Title,
                    Feature1_Des = item.Feature1_Des,
                    Feature2_Title = item.Feature2_Title,
                    Feature2_Des = item.Feature2_Des,
                    Feature3_Title = item.Feature3_Title,
                    Feature3_Des = item.Feature3_Des,
                    Feature4_Title = item.Feature4_Title,
                    Feature4_Des = item.Feature4_Des,

                    En_Name = EntrepreneurService.Get(item.En_Post_Email).FirstName + " " + EntrepreneurService.Get(item.En_Post_Email).LastName
                };
                ideas.Add(model);
            }
            return ideas;
        }

        public static IdeaModel GetByEnEmail(string email)
        {
            var item = DataAccessFactory.IdeaDataByEmailAccess().GetByEnEmail(email);
            if (item != null)
            {
                IdeaModel model = new IdeaModel()
                {
                    PostId = item.PostId,
                    En_Post_Email = item.En_Post_Email,
                    In_Asp_Email = item.In_Asp_Email,
                    Company_Name = item.Company_Name,
                    Moto = item.Moto,
                    Description = item.Description,
                    Post_Time = item.Post_Time,
                    Asking_Amount = item.Asking_Amount,
                    Asking_Share = item.Asking_Share,
                    Status = item.Status,
                    Message = item.Message,
                    Offer_Amount = item.Offer_Amount,
                    Offer_Share = item.Offer_Share,
                    Img = item.Img,
                    Category = item.Category,
                    Total_Profit = item.Total_Profit,
                    Last_Month_profit = item.Last_Month_profit,
                    Last_Year_Profit = item.Last_Year_Profit,
                    Valuation = item.Valuation,
                    Feature1_Title = item.Feature1_Title,
                    Feature1_Des = item.Feature1_Des,
                    Feature2_Title = item.Feature2_Title,
                    Feature2_Des = item.Feature2_Des,
                    Feature3_Title = item.Feature3_Title,
                    Feature3_Des = item.Feature3_Des,
                    Feature4_Title = item.Feature4_Title,
                    Feature4_Des = item.Feature4_Des,

                    En_Name = EntrepreneurService.Get(item.En_Post_Email).FirstName + " " + EntrepreneurService.Get(item.En_Post_Email).LastName
                };
                return model;
            }

            return null;
        }
    }
}
