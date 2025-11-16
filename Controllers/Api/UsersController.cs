using IdentityExpress.Identity;
using Microsoft.AspNetCore.Mvc;
using OpenApiIssueRepro.Services;

namespace OpenApiIssueRepro.Controllers.Api
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IdentityServerUserManager<IdentityExpressUser> _userManager;
        private readonly SomeService _someService;

        public UsersController(IdentityServerUserManager<IdentityExpressUser> userManager, SomeService someService)
        {
            _userManager = userManager;
            _someService = someService;
        }

        /// <summary>
        /// Get all users
        /// </summary>
        /// <examples>rer</examples>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetUsers()
        {
            var users = new[]
            {
                new { Id = 1, Name = "Alice" },
                new { Id = 2, Name = "Bob" }
            };
            return Ok(users);
        }
    }
}
