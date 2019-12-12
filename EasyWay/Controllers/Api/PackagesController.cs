using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.Entity;
using EasyWay.Dtos;
using EasyWay.Models;
using AutoMapper;

namespace EasyWay.Controllers.Api
{
    public class PackagesController : ApiController
    {
        private ApplicationDbContext _context;

        public PackagesController()
        {
            _context = new ApplicationDbContext();
        }


        //GET  /api/packages
        [HttpGet]
        public IEnumerable<PackageDto> GetPackages()
        {
            return _context.Packages.Include(p => p.SizeOfPackage).Include(p => p.ChargeOfPackage).ToList().Select(Mapper.Map<Package, PackageDto>);
        }



        //GET  /api/packages/1
        [HttpGet]
        public IHttpActionResult GetPackage(int id)
        {
            var package = _context.Packages.SingleOrDefault(p => p.Id == id);

            if (package == null)
                return NotFound();
            return Ok(Mapper.Map<Package, PackageDto>(package));
        }


        //POST  /api/packages
        [HttpPost]
        public IHttpActionResult CreatePackage(PackageDto packageDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var package = Mapper.Map<PackageDto, Package>(packageDto);
            _context.Packages.Add(package);
            _context.SaveChanges();

            packageDto.Id = package.Id;

            return Created(new Uri(Request.RequestUri + "/" + package.Id), packageDto);
        }



        //PUT  /api/package/1
        [HttpPut]
        public void UpdatePackage(int id, PackageDto packageDto)
        {
            if(!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var packageInDb = _context.Packages.SingleOrDefault(p => p.Id == id);

            if (packageInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            
            Mapper.Map<PackageDto, Package>(packageDto, packageInDb);

            _context.SaveChanges();

        }


        //DELETE  /api/package/1
        [HttpDelete]
        public void DeletePackage(int id)
        {
            var packageInDb = _context.Packages.SingleOrDefault(p => p.Id == id);

            if(packageInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _context.Packages.Remove(packageInDb);
            _context.SaveChanges();
        }
    }
}
