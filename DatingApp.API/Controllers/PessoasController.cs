using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DatingApp.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace DatingApp.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]    
    public class PessoasController: Controller
    {
         private readonly DataContext _context;

        public PessoasController(DataContext context)
        {
            _context = context;
        }
        
        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> GetPessoas()
        {
            var values = await _context.Pessoas.ToListAsync();
            return Ok(values);
        }

        [AllowAnonymous]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPessoa(int id)
        {
            var value = await _context.Pessoas.FirstOrDefaultAsync(x => x.Id == id);

            return Ok(value);
        }
    }
}