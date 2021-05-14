using FBCalzado.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace FBCalzado.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoIdentificacionController : ControllerBase
    {
        private readonly PRUEBAContext _context;

        public TipoIdentificacionController(PRUEBAContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var providers = await _context.TipoIdentificacions.ToListAsync();
                return Ok(providers);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] TipoIdentificacion tipoIdentificacion)
        {
            try
            {
                _context.Add(tipoIdentificacion);
                await _context.SaveChangesAsync();
                return Ok(tipoIdentificacion);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
    }
}
