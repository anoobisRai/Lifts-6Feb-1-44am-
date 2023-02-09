using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Lifts.Server.Data;
using Lifts.Server.IRepository;
using Lifts.Shared.Domain;

namespace Lifts.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class BookingsController : ControllerBase
    {
        //Refractored
        //private readonly
        private readonly IUnitOfWork _unitOfWork;

        //public BookingsController(ApplicationDbContext context)
        public BookingsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Bookings
        [HttpGet]
        //refractored
        public async Task<IActionResult> GetBookings()
        {
            //return await _context.Bookings.ToListAsync();
            var Bookings = await _unitOfWork.Bookings.GetAll(includes: q => q.Include(x =>x.Customer).Include(x => x.Staff).Include(x => x.Vehicle));
            return Ok(Bookings);
        }



        // GET: api/Bookings/5
        [HttpGet("{id}")]
        //refractored
        //
        public async Task<IActionResult> GetBookings(int id)
        {
            var Bookings = await _unitOfWork.Bookings.Get(q => q.Id == id);

            if (Bookings == null)
            {
                return NotFound();
            }

            //
            return Ok(Bookings);
        }

        // PUT: api/Bookings/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBookings(int id, Booking Bookings)
        {
            if (id != Bookings.Id)
            {
                return BadRequest();
            }

            //

            //_context.Entry(Bookings).State = EntityState.Modified;
            _unitOfWork.Bookings.Update(Bookings);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                //
                //if (!BookingsExists(id))
                if (!await BookingsExists(id))
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

        // POST: api/Bookings
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Booking>> PostBookings(Booking Bookings)
        {
            //_context.Bookings.Add(Bookings);
            //await _context.SaveChangesAsync();

            await _unitOfWork.Bookings.Insert(Bookings);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetBookings", new { id = Bookings.Id }, Bookings);
        }

        // DELETE: api/Bookings/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBookings(int id)
        {
            var Bookings = await _unitOfWork.Bookings.Get(q => q.Id == id);
            if (Bookings == null)
            {
                return NotFound();
            }

            //
            //_context.Bookings.Remove(Bookings);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Bookings.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }
        //
        //
        private async Task<bool> BookingsExists(int id)
        {
            //
            //return _context.Bookings.Any(e => e.Id == id);

            var Bookings = await _unitOfWork.Bookings.GetAll();
            return Bookings != null;
        }
    }
}
