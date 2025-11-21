using FuturoTrabalhoApi.Data;
using FuturoTrabalhoApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FuturoTrabalhoApi.Controllers.v1
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class HabilidadesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public HabilidadesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/v1/Habilidades
        /// <summary>
        /// Retorna a lista de todas as habilidades cadastradas.
        /// </summary>
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<Habilidade>), 200)]
        public async Task<ActionResult<IEnumerable<Habilidade>>> GetHabilidades()
        {
            return await _context.Habilidades.ToListAsync();
        }

        // GET: api/v1/Habilidades/5
        /// <summary>
        /// Retorna uma habilidade específica pelo seu ID.
        /// </summary>
        /// <param name="id">ID da habilidade.</param>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(Habilidade), 200)]
        [ProducesResponseType(404)]
        public async Task<ActionResult<Habilidade>> GetHabilidade(int id)
        {
            var habilidade = await _context.Habilidades.FindAsync(id);

            if (habilidade == null)
            {
                return NotFound(); // 404 Not Found
            }

            return Ok(habilidade); // 200 OK
        }

        // POST: api/v1/Habilidades
        /// <summary>
        /// Cria uma nova habilidade.
        /// </summary>
        /// <param name="habilidade">Dados da nova habilidade.</param>
        [HttpPost]
        [ProducesResponseType(typeof(Habilidade), 201)]
        [ProducesResponseType(400)]
        public async Task<ActionResult<Habilidade>> PostHabilidade(Habilidade habilidade)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState); // 400 Bad Request
            }

            _context.Habilidades.Add(habilidade);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetHabilidade), new { id = habilidade.Id }, habilidade); // 201 Created
        }

        // PUT: api/v1/Habilidades/5
        /// <summary>
        /// Atualiza uma habilidade existente.
        /// </summary>
        /// <param name="id">ID da habilidade a ser atualizada.</param>
        /// <param name="habilidade">Novos dados da habilidade.</param>
        [HttpPut("{id}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> PutHabilidade(int id, Habilidade habilidade)
        {
            if (id != habilidade.Id)
            {
                return BadRequest(); // 400 Bad Request
            }

            _context.Entry(habilidade).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HabilidadeExists(id))
                {
                    return NotFound(); // 404 Not Found
                }
                else
                {
                    throw;
                }
            }

            return NoContent(); // 204 No Content
        }

        // DELETE: api/v1/Habilidades/5
        /// <summary>
        /// Exclui uma habilidade.
        /// </summary>
        /// <param name="id">ID da habilidade a ser excluída.</param>
        [HttpDelete("{id}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> DeleteHabilidade(int id)
        {
            var habilidade = await _context.Habilidades.FindAsync(id);
            if (habilidade == null)
            {
                return NotFound(); // 404 Not Found
            }

            _context.Habilidades.Remove(habilidade);
            await _context.SaveChangesAsync();

            return NoContent(); // 204 No Content
        }

        private bool HabilidadeExists(int id)
        {
            return _context.Habilidades.Any(e => e.Id == id);
        }
    }
}
