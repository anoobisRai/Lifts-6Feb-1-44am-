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
    public class StaffsController : ControllerBase
    {
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;
        /*public CustomersController(ApplicationDbContext context)
        {
            _context = context;
        }*/

        public StaffsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Staffs
        /*[HttpGet]
        public async Task<ActionResult<IEnumerable<Customer>>> GetStaffs()
        {
            return await _context.Staffs.ToListAsync();
        }*/
        [HttpGet]
        public async Task<IActionResult> GetStaffs()
        {
            var Staffs = await _unitOfWork.Staffs.GetAll();
            return Ok(Staffs);
        }
        // GET: api/Staffs/5
        //[HttpGet("{id}")]
        /*public async Task<ActionResult<Staffs>> GetStaff(int id)
        {
            var Staffs = await _context.Staffs.FindAsync(id);

            if (Staffs == null)
            {
                return NotFound();
            }

            return Staffs;
        }*/
        [HttpGet("{id}")]
        public async Task<IActionResult> GetStaff(int id)
        {
            var Staff = await _unitOfWork.Staffs.Get(q => q.Id == id);

            if (Staff == null)
            {
                return NotFound();
            }

            return Ok(Staff);
        }


        // PUT: api/Staffs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStaffs(int id, Staff Staff)
        {
            if (id != Staff.Id)
            {
                return BadRequest();
            }

            //_context.Entry(Staffs).State = EntityState.Modified;
            _unitOfWork.Staffs.Update(Staff);

            try
            {
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                //if (!StaffsExists(id))
                if (!await StaffsExists(id))
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

        // POST: api/Staffs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Staff>> PostStaff(Staff Staff)
        {
            //_context.Staffs.Add(Staffs);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Customers.Insert(Staff);
            await _unitOfWork.Save(HttpContext);
            return CreatedAtAction("GetStaff", new { id = Staff.Id }, Staff);
        }

        // DELETE: api/Staffs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStaff(int id)
        {
            //var Staffs = await _context.Staffs.FindAsync(id);
            var Staff = await _unitOfWork.Staffs.Get(q => q.Id == id);
            if (Staff == null)
            {
                return NotFound();
            }

            //_context.Staffs.Remove(Staffs);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Staffs.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        //private bool CustomerExists(int id)
        private async Task<bool> StaffsExists(int id)
        {
            //return _context.Customers.Any(e => e.Id == id);
            var Staff = await _unitOfWork.Staffs.Get(q => q.Id == id);
            return Staff != null;
        }
    }
}
