using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EasyWay.Models;
using EasyWay.Dtos;

namespace EasyWay.Controllers.Api
{
    public class NewTripsController : ApiController
    {
        private ApplicationDbContext _context;


        public NewTripsController()
        {
            _context = new ApplicationDbContext();
        }



        [HttpPost]
        public IHttpActionResult CreateNewTrips(NewTripDto newTrip)
        {
            


            var driver = _context.Drivers.Single(d => d.Id == newTrip.DriverId);
            
            
            var car = _context.Cars.Single(c => c.Id == newTrip.CarId);
           

            var packages = _context.Packages.Where(p => newTrip.PackageIds.Contains(p.Id)).ToList();

            

            foreach(var package in packages)
            {
                var trip = new Trip
                {
                    Driver = driver,
                    Car = car,
                    Package = package,
                    DateLeftTheStore = DateTime.Now
                };


                _context.Trips.Add(trip);
            }

            _context.SaveChanges();

            return Ok();

        }

    }



}
