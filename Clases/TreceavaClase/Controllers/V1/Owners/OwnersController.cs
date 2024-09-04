using Bogus.DataSets;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TreceavaClase.Data;
using TreceavaClase.Models;

namespace TreceavaClase.Controllers.V1.Owners
{
    [ApiController]
    [Route("api/V1/Owners")]
    public class OwnersController : ControllerBase
    {
        private readonly ApplicationDbContext ConnectionDB;

        public OwnersController(ApplicationDbContext conectionVariables)
        {
            ConnectionDB = conectionVariables;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            //Read the owners of the data base
            var ObtainedOwners = await ConnectionDB.Owners.ToListAsync();
            return Ok(ObtainedOwners);
        }

        [HttpGet("by-id/{id}")]
        public async Task<IActionResult> GetByID(int id)
        {
            var OwnerBroughtFromDB = await ConnectionDB.Owners.FindAsync(id);
            if (OwnerBroughtFromDB == null)
            {
                return NotFound($"There was not any owner with the id: {id}");
            }            // Devuelve el propietario.
            return Ok(OwnerBroughtFromDB);
        }

        [HttpGet("by-name/{Name}")]
        public async Task<IActionResult> GetByName(string Name)
        {
            var OwnerBroughtFromDB = await ConnectionDB.Owners.FirstOrDefaultAsync(p => p.Name.Contains(Name));
            if (OwnerBroughtFromDB == null)
            {
                return NotFound($"There was not any owner with the Name: {Name}");
            }            // Devuelve el propietario.
            return Ok(OwnerBroughtFromDB);
        }

        [HttpGet("by-initial/{initial}")]
        public async Task<IActionResult> GetOwnerByInitial(string initial)
        {
            var OwnerBroughtFromDB = await ConnectionDB.Owners.Where(p => p.Name.StartsWith(initial)).ToListAsync();
            return Ok(OwnerBroughtFromDB);
        }
    }
}


