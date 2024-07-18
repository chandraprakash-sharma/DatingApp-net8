using API.Data;
using API.Entites;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API;


[ApiController]
[Route("api/[controller]")] //api/users/
public class UsersController(DataContext context) : ControllerBase
{

    [HttpGet]
    public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers(){
         var users = await context.Users.ToListAsync();
         return users;
         //retutn Ok(users) BadRequest() NotFound()    using ActionResult we have access of differenet type of return types
    }
    [HttpGet("{id}")] //api/users/{`}
    public async Task<ActionResult<AppUser>> GetUser(int id){
         var user = await context.Users.FindAsync(id);
        if(user == null){
            return NotFound();        
        }
         return user;
         //retutn Ok(users) BadRequest() NotFound()    using ActionResult we have access of differenet type of return types
    }

}
