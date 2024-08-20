using Azure.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using OLIVIA_S_BAKERY___BACKEND.model;

namespace OLIVIA_S_BAKERY___BACKEND.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public UserController(ApplicationDbContext context)
        {
            this.context = context;
        }
        [HttpPost("login")]
        public User Login([FromBody] Login model)
        {
            User user = context.Users.Where(u => u.UserName == model.userName && u.Password == model.password).FirstOrDefault();
            if (user != null)
            {
                
            }
            return user;
        }

        [HttpGet("get")]
        public List<User> GetUsers()
        {
            var users = context.Users.ToList();
            return users;
        }

        [HttpPost("create")]
        public User CreateUser([FromBody] ApiUser model)
        {
            User user = new User
            {
                Name = model.name,
                LastName= model.lastName,
                Email = model.email,
                UserName = model.userName,
                Password = model.password,
                Date = DateTime.Now
            };
            context.Users.Add(user);
            context.SaveChanges();
            return user;
        }
    }
}

