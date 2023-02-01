using GiphyIntegration.Api.Client;
using GiphyIntegration.Api.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GiphyIntegration.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GiphyController : ControllerBase
    {
        private readonly IClient _client;

        public GiphyController(IClient client)
        {
            _client = client;
        }

        [HttpGet]
        [Route("GetTrending")]
        public IActionResult GetTrending()
        {
            try
            {
                var response = _client.GetTrending(); ;
                return Ok(response);
            }
            catch (Exception)
            {

                return BadRequest();
            }

        }

        [HttpGet]
        [Route("Search")]
        public IActionResult Search(string q)
        {
            try
            {
                var response = _client.GetSearch(q); ;
                return Ok(response);
            }
            catch (Exception)
            {

                return BadRequest();
            }

        }
    }
}
