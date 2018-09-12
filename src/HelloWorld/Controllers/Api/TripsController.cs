using HelloWorld.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Controllers.Api
{
    [Route("/api/trips/")]
    public class TripsController:Controller
    {
        private HelloWorldContext _context;

        public TripsController(HelloWorldContext context)
        {
            _context = context;
        }

        [HttpGet("")]
        public IActionResult get()
        {
            try
            {
                return Ok(_context.Trips.ToList());
            }
            catch (Exception)
            {
                
            }
            return BadRequest("Failed to get trips");
        }
    }
}
