using BusinessLayer.Abstract;
using DataAccessLayer;
using EntitiyLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NbaWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamsController : ControllerBase
    {
        private INbaService<Teams> db;
        private DataContext context;
        public TeamsController(INbaService<Teams> _db,DataContext _context)
        {
            db = _db;
            context = _context;
        }
        [HttpGet("{id}")]
        public IActionResult GetbyID(int id)
        {
            
                var data = context.takimlar.Include(x => x.Players).FirstOrDefault(x => x.TeamsID == id);
                return Ok(data);
            


        }
        [HttpGet]
        public async Task<List<Teams>> Listele()
        {

            var players = await context.takimlar.Include(x => x.Players).ToListAsync();
            return players;

        }
    }
}
