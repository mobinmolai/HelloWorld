using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Models
{
    public class HelloWorldContextSeedData
    {
        private HelloWorldContext _context;

        public HelloWorldContextSeedData(HelloWorldContext context)
        {
            _context = context;
        }

        public async Task SeedData()
        {
            if (!_context.Trips.Any())
            {
                Trips _trip = new Trips()
                {
                    Name = "New Trip",
                    DateCreated = DateTime.UtcNow
                };

                _context.Trips.Add(_trip);
                _context.SaveChanges();
                var stops = new List<Stops>() {
                        new Stops() { Name= "Murree", Latitude= 33, Longitude = -84, Arrival = new DateTime(2015, 6, 4), TripId = _trip.Id },
                        new Stops() { Name= "Swat", Latitude= 33, Longitude = -84, Arrival = new DateTime(2015, 6, 4), TripId = _trip.Id }
                    };
                _context.Stops.AddRange(stops);
                await _context.SaveChangesAsync();
            }
        }
    }
}
