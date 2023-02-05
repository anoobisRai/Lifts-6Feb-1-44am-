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
    public class VehicleBrandsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public VehicleBrandsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/VehicleBrands
        [HttpGet]
        public async Task<IActionResult> GetBrands()
        {
            var Brands = await _unitOfWork.Brands.GetAll();
            return Ok(Brands);
        }

        // GET: api/VehicleBrands/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetVehicleBrand(int id)
        {
            var Brands = await _unitOfWork.Brands.Get(q => q.Id == id);

            if (Brands == null)
            {
                return NotFound();
            }

            return Ok(Brands);
        }

        // PUT: api/VehicleBrands/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVehicleBrand(int id, VehicleBrand vehicleBrand)
        {
            if (id != vehicleBrand.Id)
            {
                return BadRequest();
            }

            _unitOfWork.Brands.Update(vehicleBrand);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await VehicleBrandExists(id))
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

        // POST: api/VehicleBrands
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<VehicleBrand>> PostVehicleBrand(VehicleBrand vehicleBrand)
        {
            await _unitOfWork.Brands.Insert(vehicleBrand);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetVehicleBrand", new { id = vehicleBrand.Id }, vehicleBrand);
        }

        // DELETE: api/VehicleBrands/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVehicleBrand(int id)
        {
            var vehicleBrand = await _unitOfWork.Brands.Get(q => q.Id == id);
            if (vehicleBrand == null)
            {
                return NotFound();
            }

            await _unitOfWork.Brands.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> VehicleBrandExists(int id)
        {
            var vehicleBrand = await _unitOfWork.Brands.Get(q => q.Id == id);
            return vehicleBrand != null;
        }
    }
}
