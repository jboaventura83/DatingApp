using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DatingApp.API.Data;

namespace DatingApp.API.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private readonly DataContext _context;

        public ValuesController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetPessoas()
        {
            var values = _context.Pessoas.ToList();
            return Ok(values);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult GetPessoa(int id)
        {
            var value = _context.Pessoas.FirstOrDefault(x => x.Id == id);

            return Ok(value);
        }

       
    }
}
