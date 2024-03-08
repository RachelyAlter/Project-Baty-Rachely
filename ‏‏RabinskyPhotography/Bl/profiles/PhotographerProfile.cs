using AutoMapper;
using Bl.BlModels;
using Dal.Do;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl.profiles
{
    internal class PhotographerProfile:Profile 
    {
        public PhotographerProfile()
        {
            CreateMap<Photographer,BLPhotographer>().ReverseMap();
        }
       
    }
}
