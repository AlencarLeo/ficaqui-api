using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ficaqui_api.Models;

namespace ficaqui_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SearchController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var search = new List<Search> 
            {
                new Search 
                {
                    Id = 1,
                    Name = "Leonardo"
                }
            };

            return Ok(search);
        }
    }
}