using Microsoft.AspNetCore.Mvc;

namespace CalculatorApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        [HttpGet("add")]
public ActionResult<decimal> Add(decimal num1, decimal num2)
{
    return Ok(num1 + num2);
}

        [HttpGet("subtract")]
public ActionResult<decimal> Subtract(decimal num1, decimal num2)
{
    return Ok(num1 - num2);
}

        [HttpGet("multiply")]
public ActionResult<decimal> Multiply(decimal num1, decimal num2)
{
    return Ok(num1 * num2);
}

        [HttpGet("divide")]
public ActionResult<decimal> Divide(decimal num1, decimal num2)
{
    if (num2 == 0) return BadRequest("Division by zero is not allowed.");
    return Ok(num1 / num2);
}

        [HttpGet("modulo")]
public ActionResult<decimal> Modulo(decimal num1, decimal num2)
{
    if (num2 == 0) return BadRequest("Modulo by zero is not allowed.");
    return Ok(num1 % num2);
}

    }
    
}



