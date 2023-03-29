using core7_identity_jwt_basic_auth.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace core7_identity_jwt_basic_auth.Controllers;

public class AuthController : ControllerBase
{
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly RoleManager<IdentityRole> _roleManager;
    private readonly IConfiguration _configuration;
    public AuthController(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager, IConfiguration configuration)
    {
        _userManager = userManager;
        _roleManager = roleManager;
        _configuration = configuration;
    }
    //
    // [HttpPost]
    // [Route("register")]
    //
    // public async Task<IActionResult> Register([FromBody] RegisterModel model)
    // {
    //     
    // }
  
}