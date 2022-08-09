using AutoMapper;
using DAL.EF;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Mapper
{
    public class In_MappingProfile : Profile
    {
        public In_MappingProfile()
        {
            CreateMap<Investor, InvestorModel>();
        }
        
    }
}
