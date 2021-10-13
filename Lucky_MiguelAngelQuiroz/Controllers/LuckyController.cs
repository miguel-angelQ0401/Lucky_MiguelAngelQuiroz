using Lucky_MiguelAngelQuiroz.Data;
using Lucky_MiguelAngelQuiroz.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lucky_MiguelAngelQuiroz.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LuckyController : ControllerBase
    {
        private readonly AppDbContext _context;

        public LuckyController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<Suerte>> GetSuerte()
        {

            var list = await _context.Lucky_MiguelAngelQuiroz.ToListAsync();

            var max = list.Count;
            int index = new Random().Next(0, max);

            var cancion = list[index];

            if (cancion == null)
            {
                return NoContent();
            }

            return cancion;
        }
    }
}
