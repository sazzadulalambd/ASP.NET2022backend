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
    public class OfferServices
    {
        public static List<OfferModel> Get()
        {
            var data = DataAccessFactory.OfferDataAccess().Get();
            var offers = new List<OfferModel>();

            foreach (var item in data)
            {
                var O = new OfferModel()
                {
                    Id = item.Id,
                    In_Email = item.In_Email,
                    En_Email = item.En_Email,
                    Title = item.Title,
                    Description = item.Description,
                    Ideas_Id = item.Ideas_Id,
                    Offered_Share = item.Offered_Share,
                    Offered_Amount = item.Offered_Amount
                };
                
                var idea = IdeaServices.Get(item.Ideas_Id);
                O.Company_Name = idea.Company_Name;
                O.Moto = idea.Moto;
                O.Category = idea.Category;
                O.Asking_Amount = idea.Asking_Amount;
                O.Asking_Share = idea.Asking_Share;
                O.Total_Profit = idea.Total_Profit;
                O.Last_Month_profit = idea.Last_Month_profit;
                O.Last_Year_Profit = idea.Last_Year_Profit;
                O.Valuation = idea.Valuation;

                var En = EntrepreneurService.Get(item.En_Email);
                O.FirstName = En.FirstName;
                O.LastName = En.LastName;

                offers.Add(O);
            }
            return offers;
        }

        public static OfferModel Get(int id)
        {
            var item = DataAccessFactory.OfferDataAccess().Get(id);

            var O = new OfferModel()
            {
                Id = item.Id,
                In_Email = item.In_Email,
                En_Email = item.En_Email,
                Title = item.Title,
                Description = item.Description,
                Ideas_Id = item.Ideas_Id,
                Offered_Share = item.Offered_Share,
                Offered_Amount = item.Offered_Amount
            };

            var idea = IdeaServices.Get(item.Ideas_Id);
            O.Company_Name = idea.Company_Name;
            O.Moto = idea.Moto;
            O.Category = idea.Category;
            O.Asking_Amount = idea.Asking_Amount;
            O.Asking_Share = idea.Asking_Share;
            O.Total_Profit = idea.Total_Profit;
            O.Last_Month_profit = idea.Last_Month_profit;
            O.Last_Year_Profit = idea.Last_Year_Profit;
            O.Valuation = idea.Valuation;

            var En = EntrepreneurService.Get(item.En_Email);
            O.FirstName = En.FirstName;
            O.LastName = En.LastName;

            return O;
        }

        public static bool Create(OfferModel item)
        {
            var O = new Offer()
            {
                Id = item.Id,
                In_Email = item.In_Email,
                En_Email = item.En_Email,
                Title = item.Title,
                Description = item.Description,
                Ideas_Id = item.Ideas_Id,
                Offered_Share = item.Offered_Share,
                Offered_Amount = item.Offered_Amount
            };

            return DataAccessFactory.OfferDataAccess().Create(O);
        }

        public static bool Update(OfferModel item)
        {
            var O = new Offer()
            {
                Id = item.Id,
                In_Email = item.In_Email,
                En_Email = item.En_Email,
                Title = item.Title,
                Description = item.Description,
                Ideas_Id = item.Ideas_Id,
                Offered_Share = item.Offered_Share,
                Offered_Amount = item.Offered_Amount
            };

            return DataAccessFactory.OfferDataAccess().Update(O);
        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.OfferDataAccess().Delete(id);
        }

        public static List<OfferModel> MySentOffer(string email)
        {
            var data = DataAccessFactory.OfferMoreDataAccess().MySentOffer(email);
            var offers = new List<OfferModel>();

            foreach (var item in data)
            {
                var O = new OfferModel()
                {
                    Id = item.Id,
                    In_Email = item.In_Email,
                    En_Email = item.En_Email,
                    Title = item.Title,
                    Description = item.Description,
                    Ideas_Id = item.Ideas_Id,
                    Offered_Share = item.Offered_Share,
                    Offered_Amount = item.Offered_Amount
                };

                var idea = IdeaServices.Get(item.Ideas_Id);
                O.Company_Name = idea.Company_Name;
                O.Moto = idea.Moto;
                O.Category = idea.Category;
                O.Asking_Amount = idea.Asking_Amount;
                O.Asking_Share = idea.Asking_Share;
                O.Total_Profit = idea.Total_Profit;
                O.Last_Month_profit = idea.Last_Month_profit;
                O.Last_Year_Profit = idea.Last_Year_Profit;
                O.Valuation = idea.Valuation;

                var En = EntrepreneurService.Get(item.En_Email);
                O.FirstName = En.FirstName;
                O.LastName = En.LastName;

                offers.Add(O);
            }
            return offers;
        }

        public static bool DeleteByInEmail(string email)
        {
            return DataAccessFactory.OfferMoreDataAccess().DeleteByInEmail(email);
        }
    }
}
