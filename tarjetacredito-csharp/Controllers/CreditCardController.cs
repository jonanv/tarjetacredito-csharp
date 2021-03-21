using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using tarjetacredito_csharp.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace tarjetacredito_csharp.Controllers
{
    [Route("api/[controller]")]
    public class CreditCardController : Controller
    {
        // Declaration del contexto
        private readonly ApplicationDbContext _context;

        public CreditCardController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/<CreditCard>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var creditCardList = await _context.CreditCard.ToListAsync();
                return Ok(creditCardList);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST api/<CreditCard>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreditCard creditCard)
        {
            try
            {
                _context.Add(creditCard);
                await _context.SaveChangesAsync();
                return Ok(creditCard);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT api/<CreditCard>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] CreditCard creditCard)
        {
            try
            {
                if (id != creditCard.Id || id == 0)
                {
                    return NotFound();
                }
                else
                {
                    _context.Update(creditCard);
                    await _context.SaveChangesAsync();
                    return Ok(new { message = "La tarjeta fue actualizada con exito!" });
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE api/<CreditCard>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var creditCard = await _context.CreditCard.FindAsync(id);
                if (creditCard == null)
                {
                    return NotFound();
                }
                _context.CreditCard.Remove(creditCard);
                await _context.SaveChangesAsync();
                return Ok(new { message = "La tarjeta fue eliminado con exito!" });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
