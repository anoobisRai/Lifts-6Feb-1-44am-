using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Lifts.Server.Data;
using Lifts.Shared.Domain;
using Lifts.Server.IRepository;

namespace Lifts.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiclesController : ControllerBase
    {
        //Refactored
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitofWork;
        //Refactored


        //public VehiclesController(ApplicationDbContext context)
        public VehiclesController(IUnitOfWork unitOfWork)
        {
            //Refactored
            //_context = context;
            _unitofWork = unitOfWork;

        }

        // GET: api/Vehicles
        [HttpGet]
        //Refactored
        //public async Task<ActionResult<IEnumerable<Vehicle>>> GetVehicles()
        public async Task<IActionResult> GetVehicles()
        {
            //Refactored
            //return await _context.Vehicles.ToListAsync();
            var vehicles = await _unitofWork.Vehicles.GetAll(includes: q => q.Include(x => x.Brand).Include(x => x.Type).Include(x => x.Seater));
            return Ok(vehicles);
        }

        // GET: api/Vehicles/5
        [HttpGet("{id}")]
        //Refactored
        //public async Task<ActionResult<Vehicle>> GetVehicle(int id)
        public async Task<IActionResult> GetVehicle(int id)
        {
            //var vehicle = await _context.Vehicles.FindAsync(id);
            var vehicle = await _unitofWork.Vehicles.Get(q => q.Id == id);

            if (vehicle == null)
            {
                return NotFound();
            }

            return Ok(vehicle);
        }

        // PUT: api/Vehicles/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVehicle(int id, Vehicle vehicle)
        {
            if (id != vehicle.Id)
            {
                return BadRequest();
            }
            //Refactored
            //_context.Entry(vehicle).State = EntityState.Modified;
            _unitofWork.Vehicles.Update(vehicle);


            try
            {
                //await _context.SaveChangesAsync();
                await _unitofWork.Save(HttpContext);

            }
            catch (DbUpdateConcurrencyException)
            {
                //Refactored
                //if (!VehicleExists(id))
                if (!await VehicleExists(id))
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

        // POST: api/Vehicles
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Vehicle>> PostVehicle(Vehicle vehicle)
        {
            //_context.Vehicles.Add(vehicle);
            //await _context.SaveChangesAsync();
            await _unitofWork.Vehicles.Insert(vehicle);
            await _unitofWork.Save(HttpContext);


            return CreatedAtAction("GetVehicle", new { id = vehicle.Id }, vehicle);
        }

        // DELETE: api/Vehicles/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVehicle(int id)
        {
            //var vehicle = await _context.Vehicles.FindAsync(id);
            var vehicle = await _unitofWork.Vehicles.Get(q => q.Id == id);
            if (vehicle == null)
            {
                return NotFound();
            }

            //_context.Vehicles.Remove(vehicle);
            //await _context.SaveChangesAsync();
            await _unitofWork.Vehicles.Delete(id);
            await _unitofWork.Save(HttpContext);

            return NoContent();
        }

        //private bool VehicleExists(int id)
        private async Task<bool> VehicleExists(int id)
        {
            //return _context.Vehicles.Any(e => e.Id == id);
            var vehicle = _unitofWork.Vehicles.Get(q => q.Id == id);
            return vehicle != null;
        }
    }
}
