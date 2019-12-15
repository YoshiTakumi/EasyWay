using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoMapper;
using EasyWay.Models;
using EasyWay.Dtos;

namespace EasyWay.Controllers.Api
{
    public class CarsController : ApiController
    {
        private ApplicationDbContext _context;

        public CarsController()
        {
            _context = new ApplicationDbContext();

        }


        //GET  /api/cars
        [HttpGet]
        public IEnumerable<CarDto> GetCars()
        {
            return _context.Cars.ToList().Select(Mapper.Map<Car, CarDto>);
        }


        //GET  /api/cars/1
        [HttpGet]
        public IHttpActionResult GetCar(int id)
        {
            var car = _context.Cars.SingleOrDefault(c => c.Id == id);

            if (car == null)
                return NotFound();
            return Ok(Mapper.Map<Car, CarDto>(car));
        }


        //POST  /api/cars/1
        [HttpPost]
        [Authorize(Roles = RoleName.CanManagePackages)]
        public IHttpActionResult CreateCar(CarDto carDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var car = Mapper.Map<CarDto, Car>(carDto);
            _context.Cars.Add(car);
            _context.SaveChanges();

            carDto.Id = car.Id;

            return Created(new Uri(Request.RequestUri + "/" + car.Id), carDto);
        }



        //PUT  /api/cars/1
        [HttpPut]
        [Authorize(Roles = RoleName.CanManagePackages)]
        public void UpdateCar(int id, CarDto carDto)
        {
            if(!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var carInDb = _context.Cars.SingleOrDefault(c => c.Id == id);

            if (carInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            Mapper.Map<CarDto, Car>(carDto, carInDb);

            _context.SaveChanges();


        }


        //DELETE  /api/cars/1
        [HttpDelete]
        [Authorize(Roles = RoleName.CanManagePackages)]
        public void DeleteCar(int id)
        {
            var carInDb = _context.Cars.SingleOrDefault(p => p.Id == id);

            if (carInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _context.Cars.Remove(carInDb);
            _context.SaveChanges();
        }
    }
}

