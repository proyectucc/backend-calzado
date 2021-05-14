using FBCalzado.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace FBCalzado.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolesController : ControllerBase
    {
        private readonly PRUEBAContext _context;

        public RolesController(PRUEBAContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var roles = await (from emp in _context.Roles

                                   select new
                                   {
                                       emp.IdRol,
                                       emp.NombreRol,
                                       emp.Descripcion
                                   }).ToListAsync();

                return Ok(roles);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
