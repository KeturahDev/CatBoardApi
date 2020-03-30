using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CatBoardApi.Models;

namespace CatBoardApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BoardsController : ControllerBase
    {

        private CatBoardApiContext _db;

        public BoardsController(CatBoardApiContext db)
        {
            _db = db;
        }

        // GET api/boards
        [HttpGet]
        public ActionResult<IEnumerable<Board>> Get()
        {
            return _db.Boards.ToList();
        }

        // GET api/boards/5
        [HttpGet("{id}")]
        public ActionResult<Board> Get(int id)
        {
            Board thisBoard = _db.Boards.FirstOrDefault(board => board.BoardId == id);
            return thisBoard;
        }

        // POST api/boards
        [HttpPost]
        public void Post([FromBody] Board board)
        {
            _db.Boards.Add(board);
            _db.SaveChanges();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
