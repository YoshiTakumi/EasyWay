using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EasyWay.Models;
using EasyWay.Dtos;
using AutoMapper;

namespace EasyWay.Controllers.Api
{
    public class DriversController : ApiController
    {


        private ApplicationDbContext _context;

        public DriversController()
        {
            _context = new ApplicationDbContext();
        }


        //GET /api/drivers
        [HttpGet]
        public IEnumerable<DriverDto> GetDrivers()
        {
            return _context.Drivers.ToList().Select(Mapper.Map<Driver, DriverDto>);
        }


        //GET /api/drivers/1
        [HttpGet]
        public IHttpActionResult GetDriver(int id)
        {
            var driver = _context.Drivers.SingleOrDefault(d => d.Id == id);

            if(driver == null)
           
              return NotFound();
            

            return Ok(Mapper.Map<Driver, DriverDto>(driver));
        }


        //POST /api/drivers
        [HttpPost]
        [Authorize(Roles = RoleName.CanManagePackages)]
        public IHttpActionResult CreateDriver(DriverDto driverDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var driver = Mapper.Map<DriverDto, Driver>(driverDto);
            _context.Drivers.Add(driver);
            _context.SaveChanges();

            driverDto.Id = driver.Id;

            return Created(new Uri(Request.RequestUri + "/" + driver.Id), driverDto);
            
        }


        //PUT /api/drivers/1
        [HttpPut]
        [Authorize(Roles = RoleName.CanManagePackages)]
        public void UpdateDriver(int id, DriverDto driverDto)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var driverInDb = _context.Drivers.SingleOrDefault(d => d.Id == id);
            
            if (driverInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);


            Mapper.Map<DriverDto, Driver>(driverDto, driverInDb);
            

            _context.SaveChanges();
        }


        //DELETE /api/drivers/1
        [HttpDelete]
        [Authorize(Roles = RoleName.CanManagePackages)]
        public void DeleteCustomer(int id)
        {
            var driverInDb = _context.Drivers.SingleOrDefault(d => d.Id == id);

            if (driverInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _context.Drivers.Remove(driverInDb);
            _context.SaveChanges();

        }
    }
}
