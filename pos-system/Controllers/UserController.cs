using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using pos_system.Model;
using pos_system.Repository;

namespace pos_system.Controllers
{
    public class UserController : Controller
    {

        private UserRepository _userRepository = new UserRepository();

        [HttpPost("api/user/register")]
        public IActionResult Add([FromBody] User user)
        {
            var addedUser=_userRepository.Add(user);
            Console.WriteLine("Hit Korse");
            return Ok(addedUser);
        }

        [HttpPost("api/user/login")]
        public IActionResult Login([FromBody] User user)
        {
            var loggedIn = _userRepository.Login(user);
            Console.WriteLine("Hit Korse");
            return Ok(loggedIn);
        }

        [HttpGet("api/user/search")]
        public IActionResult Search(String username)
        {
            var user = _userRepository.Search(username);
            Console.WriteLine("Hit Korse");
            return Ok(user);
        }

        [HttpPost("api/admin/update_staff")]
        public IActionResult Update([FromBody] User user)
        {
            var updateUser = _userRepository.Update(user);
            return Ok(updateUser);
        }
    }
}
