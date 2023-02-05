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
    public class VehicleTypesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public VehicleTypesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/VehicleTypes
        [HttpGet]
        public async Task<IActionResult> GetTypes()
        {
            var Types = await _unitOfWork.Types.GetAll();
            return Ok(Types);
        }

        // GET: api/VehicleTypes/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetVehicleType(int id)
        {
            var Types = await _unitOfWork.Types.Get(q => q.Id == id);

            if (Types == null)
            {
                return NotFound();
            }

            return Ok(Types);
        }

        // PUT: api/VehicleTypes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVehicleType(int id, VehicleType vehicleType)
        {
            if (id != vehicleType.Id)
            {
                return BadRequest();
            }

            _unitOfWork.Types.Update(vehicleType);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await VehicleTypeExists(id))
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

        // POST: api/VehicleTypes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<VehicleType>> PostVehicleType(VehicleType vehicleType)
        {
            await _unitOfWork.Types.Insert(vehicleType);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetVehicleType", new { id = vehicleType.Id }, vehicleType);
        }

        // DELETE: api/VehicleTypes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVehicleType(int id)
        {
            var vehicleType = await _unitOfWork.Types.Get(q => q.Id == id);
            if (vehicleType == null)
            {
                return NotFound();
            }

            await _unitOfWork.Types.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> VehicleTypeExists(int id)
        {
            var vehicleType = await _unitOfWork.Types.Get(q => q.Id == id);
            return vehicleType != null;
        }
    }
}
