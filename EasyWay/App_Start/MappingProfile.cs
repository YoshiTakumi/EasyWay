using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using EasyWay.Dtos;
using EasyWay.Models;

namespace EasyWay.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Driver, DriverDto>();
            CreateMap<DriverDto, Driver>();
           
        }
    }
}