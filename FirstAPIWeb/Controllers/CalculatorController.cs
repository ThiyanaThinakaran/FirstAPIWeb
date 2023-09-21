using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstAPIWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        // api/calculator/add?x=28&y=01
        [HttpGet("Calculator/Add")]
        public int Add(int x, int y) 
        { 
            return x+y;
        }
        [HttpGet("Calculator/Sum")]
        public int Sum(int x, int y)
        {
            return x+y+1000;
        }
        // api/calculator/subtract?x=28&y=100

        [HttpPost]
        public int Subtract(int x, int y)
        {
            return x - y;
        }
        // api/calculator/Multiply?x=28&y=01
        [HttpPut]
        public int Multiply(int x, int y)
        {
            return x * y;
        }
        // api/calculator/Divide?x=28&y=01
        [HttpDelete]
        public int Divide(int x, int y)
        {
            return x / y;
        }
    }
}
