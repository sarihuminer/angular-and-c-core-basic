using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using server.Models;
using server.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors]
    public class UserController : ControllerBase
    {
        public UserController(IUserRepository userRepository)
        {
            UserRepository = userRepository;
        }
        public IUserRepository UserRepository { get; set; }
        [HttpGet]
        [Route("GetById/{id}")]
        //[HttpGet("{id}", Name = "GetTodo")]
        public IActionResult GetById(string id)
        {
            UserModel item = UserRepository.GetUserName(id);
            if (item == null)
            {
                return NotFound();
            }
            return Ok(item);
            //return new ObjectResult(item);
        }

        [HttpPost]
        public IActionResult Create([FromBody] UserModel user)
        {
            if (user == null)
            {
                return BadRequest();
            }
            UserRepository.Add(user);
            return CreatedAtRoute("Add_New_User", new { id = user.ID }, user);
        }
    }
}
