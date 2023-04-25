using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]

    //https://localhost:6001/api/Users
    //https://localhost:6001/api/Users/1
    public class UsersController : ControllerBase
    {
        private readonly DataContext _context;
        public  UsersController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]

      /*  public ActionResult<IEnumerable<AppUser>> GetUsers()
        {
            var Users=_context.Users.ToList();
            return Users;
        }
*/
//asyncronus code
 public async Task <ActionResult<IEnumerable<AppUser>>> GetUsers()
        {
            var Users=_context.Users.ToListAsync();
            return await Users;
        }
       
        [HttpGet("{id}")]
#nullable disable
        public async Task <ActionResult<AppUser>> GetUser(int id)
        {
            return  await _context.Users.FindAsync(id);
        }
        #nullable restore
    }
}