using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace fetch_test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet]
        [Route("SampleGet")]
        public async Task<IActionResult> SampleGet()
        {
            await Task.Delay(1);
            return Ok("Successfull SampleGet call!");
        }

        [HttpPost]
        [Route("SamplePostFromBody")]
        public async Task<IActionResult> SamplePostFromBody([FromBody] Body data)
        {
            await Task.Delay(1);
            return Ok($"Successfull SamplePostFromBody call! Num: {data.Num}, string: {data.String}");
        }

        [HttpPost]
        [Route("SamplePostFromQuery")]
        public async Task<IActionResult> SamplePostFromQuery(string query, int num)
        {
            await Task.Delay(1);
            return Ok($"Successfull SamplePostFromQuery call! Query: {query}, num: {num}");
        }

        [HttpPost]
        [Route("Combined")]
        public async Task<IActionResult> Combined([FromBody] Body data, int num)
        {
            await Task.Delay(1);
            return Ok($"Successfull Combined call!");
        }
    }
}
