using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Http.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public partial class UsersController : ControllerBase
    {

        /// <summary>
        /// some comment
        /// </summary>
        /// <returns></returns>
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return Ok();
        }
    }
}
