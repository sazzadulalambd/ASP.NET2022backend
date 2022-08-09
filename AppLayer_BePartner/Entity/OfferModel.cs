using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class OfferModel
    {
        public int Id { get; set; }
        public string In_Email { get; set; }
        public string En_Email { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Ideas_Id { get; set; }
        public string Offered_Share { get; set; }
        public string Offered_Amount { get; set; }

        public string Company_Name { get; set; }
        public string Moto { get; set; }
        public string Category { get; set; }
        public string Asking_Amount { get; set; }
        public string Asking_Share { get; set; }
        public string Total_Profit { get; set; }
        public string Last_Month_profit { get; set; }
        public string Last_Year_Profit { get; set; }
        public string Valuation { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
