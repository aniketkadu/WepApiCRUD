using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using webapicrud.Models;
using webapicrud.Dtos;

namespace webapicrud.App_Start
{
    public class MappingProfile:Profile
    {


        public MappingProfile()
        {
            CreateMap<rest, restDto>();
            CreateMap<restDto, rest>();
        }

    }
}