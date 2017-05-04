using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace swaggerbug
{
    [Route("[controller]")]
    public class TestController : Controller
    {
        // GET api/values/5
        [HttpGet()]
        public IActionResult Get()
        {
            var retLong = BitConverter.ToInt64(Guid.NewGuid().ToByteArray(), 0);
            var binary = Convert.ToString(retLong, 2);
            System.Console.WriteLine($"Long: {retLong} Binary: {binary}");
            return Ok(new { OriginalLong = retLong, Binary = binary });
        }
    }
}
