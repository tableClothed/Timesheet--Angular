using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TimeSheet.API.Data;

namespace TimeSheet.API.Controllers
{
    public class UserController : ControllerBase
    {
        private DataContext _context;

        public UserController(DataContext context)
        {
            _context = context;
        }

        // [HttpGet]
        // public IActionResult GetUsers(){
        //     //return _context.Users.ToList();
        //     return _context.Users.FirstOrDefault(u => u.UserId == 1);
        // }
    }
}