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

            //Domain to Dto
            CreateMap<Driver, DriverDto>();
            CreateMap<Package, PackageDto>();
            CreateMap<Car, CarDto>();
            CreateMap<ChargeOfPackage, ChargeOfPackageDto>();
            CreateMap<SizeOfPackage, SizeOfPackageDto>();



            //Dto to Domain
            CreateMap<DriverDto, Driver>().ForMember(d => d.Id, opt => opt.Ignore());
            CreateMap<PackageDto, Package>().ForMember(p => p.Id, opt => opt.Ignore());
            CreateMap<CarDto, Car>().ForMember(c => c.Id, opt => opt.Ignore());


        }
    }
}