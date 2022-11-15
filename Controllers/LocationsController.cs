using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LocatorBackEnd;
using LocatorBackEnd.Data;
using RestSharp;
using Newtonsoft.Json;
using System.Net.Http;
using unirest_net.http;
using System.Net;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using NuGet.Protocol;
using System.Text.Json.Nodes;
using Newtonsoft.Json.Linq;

namespace LocatorBackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class LocationsController : ControllerBase
    {
        private readonly LocatorBackEndContext _context;
        public LocationsController(LocatorBackEndContext context)
        {
            _context = context;
        }

        // GET: api/Locations
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Location>>> GetLocation()
        {
            return await _context.Location.ToListAsync();
        }

        // GET: api/Locations/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Location>> GetLocation(int id)
        {
            var location = await _context.Location.FindAsync(id);

            if (location == null)
            {
                return NotFound();
            }

            return location;
        }

        // PUT: api/Locations/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLocation(int id, Location location)
        {
            if (id != location.LocationId)
            {
                return BadRequest();
            }

            _context.Entry(location).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();  
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LocationExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Locations
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Location>> PostLocation(Location location)
        {
            _context.Location.Add(location);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLocation", new { id = location.LocationId }, location);
        }

        [HttpGet("findmotels")]
        public async Task<String> FindMotel()
        {
            WebRequest request = WebRequest.Create("https://api.foursquare.com/v3/places/search?ll=18.483402%2c-69.929611&categories=19017&limit=10");
            request.Headers.Add("Authorization", "fsq3DcI3urC/S90Oltu1fqRt+dZM+psEYVDSFgxqk276XNQ=");
            WebResponse response = request.GetResponse();
            StreamReader read = new StreamReader(response.GetResponseStream());
            string result = await read.ReadToEndAsync();
            dynamic jsonDe = JsonConvert.DeserializeObject(result);

            string latitude = jsonDe.latitude;
            string longitude = jsonDe.longitude;
            string address = jsonDe.address;
            string locality = jsonDe.locality;
            string region = jsonDe.region;
            return address; 
            //return response;
        }
        //[HttpGet("FindCabana")]
        //public async Task<string> GetMotel()
        //{

        //    WebRequest orequest = WebRequest.Create("https://api.foursquare.com/v3/places/search?query=Motel&ll=18.4861%2C-69.9312&radius=5000");

        //    orequest.Headers.Add("Authorization", "fsq3DcI3urC/S90Oltu1fqRt+dZM+psEYVDSFgxqk276XNQ=");
        //    WebResponse orespose = orequest.GetResponse();
        //    StreamReader sr = new StreamReader(orespose.GetResponseStream());
        //    return await sr.ReadToEndAsync();
        //}

        // DELETE: api/Locations/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLocation(int id)
        {
            var location = await _context.Location.FindAsync(id);
            if (location == null)
            {
                return NotFound();
            }

            _context.Location.Remove(location);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool LocationExists(int id)
        {
            return _context.Location.Any(e => e.LocationId == id);
        }
    }
}
