using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Lifts.Server.Data;
using Lifts.Shared.Domain;
using Lifts.Server.IRepository;

namespace Lifts.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleSeatersController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public VehicleSeatersController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: VehicleSeaters
        public async Task<IActionResult> GetVehicleSeaters()
        {
            var Seaters = await _unitOfWork.Seaters.GetAll();
            return Ok(Seaters);
        }

        // GET: VehicleSeaters/Details/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetVehicleSeat(int id)
        {
            var Seaters = await _unitOfWork.Seaters.Get(q => q.Id == id);

            if (Seaters == null)
            {
                return NotFound();
            }

            return Ok(Seaters);
        }

        // PUT: api/VehicleSeaters/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVehicleSeater(int id, VehicleSeater vehicleSeater)
        {
            if (id != vehicleSeater.Id)
            {
                return BadRequest();
            }
            _unitOfWork.Seaters.Update(vehicleSeater);
            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await VehicleSeaterExists(id))
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

        // POST: api/VehicleSeater
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<VehicleSeater>> PostVehicleSEater(VehicleSeater vehicleSeater)
        {
            await _unitOfWork.Seaters.Insert(vehicleSeater);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetVehicleSeater", new { id = vehicleSeater.Id }, vehicleSeater);
        }

        // DELETE: api/VehicleSeater/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVehicleSeater(int id)
        {
            var vehicleSeater = await _unitOfWork.Seaters.Get(q => q.Id == id);
            if (vehicleSeater == null)
            {
                return NotFound();
            }

            await _unitOfWork.Seaters.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> VehicleSeaterExists(int id)
        {
            var vehicleSeater = await _unitOfWork.Seaters.Get(q => q.Id == id);
            return vehicleSeater != null;
        }
    }
}
