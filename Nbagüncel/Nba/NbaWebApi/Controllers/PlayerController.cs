using BusinessLayer.Abstract;
using DataAccessLayer;
using EntitiyLayer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
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
    
    public class PlayerController : ControllerBase
    {
        private INbaService<Players> db;
        private DataContext context;
        public PlayerController(INbaService<Players> _db, DataContext _context)
        {
            db = _db;
            context = _context;
        }
        [HttpGet]
        public async Task<List<Players>> Listele()
        {
            
                var players = await context.oyuncular.Include(x => x.Teams).ToListAsync();
                return players;
            
        }
        [HttpGet("{id}")]
        public IActionResult GetbyID(int id)
        {
            
                var data = context.oyuncular.Include(x => x.Teams).FirstOrDefault(x => x.PlayersID == id);
                return Ok(data);
            
        }
        [HttpPut]
        public IActionResult Update(Players players)
        {
            if (db.GetByID(players.PlayersID) != null)
            {
                var update = db.UpdatePT(players);
                return Ok(update);
            }
            return NotFound();
        }
        [HttpPost]
        public IActionResult Create(Players players)
        {

            if (ModelState.IsValid)
            {
                var create = db.CreatePT(players);
                return Ok(create);
            }
            return BadRequest(ModelState);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (db.GetByID(id)!=null)
            {
                db.DeletePT(id);
                return Ok();
            }
            return NotFound();
        }

    }
}
