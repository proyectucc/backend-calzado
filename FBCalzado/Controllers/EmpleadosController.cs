using FBCalzado.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FBCalzado.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadosController : ControllerBase
    {
        private readonly PRUEBAContext _context;

        public EmpleadosController(PRUEBAContext context)
        {
            _context = context;
        }
        /// <summary>
        /// Método Http que permite consultar todos los registros
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var employees = await (from emp in _context.Empleados
                                       join ident in _context.TipoIdentificacions on emp.IdTipoIdent equals ident.IdTipoIdent

                                       select new
                                       {
                                           emp.IdEmpleado,
                                           emp.PrimerNombre,
                                           emp.SegundoNombre,
                                           emp.PrimerApellido,
                                           emp.SegundoApellido,
                                           ident.TipoIdent,
                                           emp.NumeroIdentificacion,
                                           emp.TelefonoCelular,
                                           emp.TelefonoFijo,
                                           emp.EmailPrincipal,
                                           emp.FechaContratacion,
                                           emp.FechaTerminacion,
                                           emp.FechaNacimiento,
                                           emp.Rol
                                       }).ToListAsync();

                return Ok(employees);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Método encargado de traer un registro por ID
        /// </summary>
        /// <param name="id">Id del registro a consultar</param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<Empleado>> GetEmpleado(int id)
        {
            var empleadoItem = await _context.Empleados.FindAsync(id);

            if (empleadoItem == null)
            {
                return NotFound();
            }

            return empleadoItem;
        }

        /// <summary>
        /// Método que se encarga de actualizar un registro
        /// </summary>
        /// <param name="empleado">Objeto con los parámetros del empleado</param>
        /// <returns></returns>
        [HttpPut]
        public async Task<ActionResult> PutEmpleado(Empleado empleado)
        {

            _context.Entry(empleado).State = EntityState.Modified;

            await _context.SaveChangesAsync();
            return NoContent();
        }

        /// <summary>
        /// Método que se ejecuta para la creación de un registro
        /// </summary>
        /// <param name="empleado">Datos del empleado</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult<Empleado>> PostEmpleado(Empleado empleado)
        {
            _context.Empleados.Add(empleado);

            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetEmpleado), new { id = empleado.IdEmpleado }, empleado);
        }

        /// <summary>
        /// Método Http para la eliminación de un registro
        /// </summary>
        /// <param name="id">Id del registro que contiene la data a eliminar</param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmpleado(int id)
        {
            var empleado = await _context.Empleados.FindAsync(id);

            if(empleado == null)
            {
                return NotFound();
            }

            _context.Empleados.Remove(empleado);

            await _context.SaveChangesAsync();

            return NoContent();
        }

    }
}
