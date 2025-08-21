using Microsoft.AspNetCore.Mvc;

namespace CalculatorApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CalculatorController : ControllerBase
{
    [HttpGet("sum")]
    public IActionResult Sum([FromQuery] double a, [FromQuery] double b)
        => Ok(new { result = a + b });

    [HttpGet("subtract")]
    public IActionResult Subtract([FromQuery] double a, [FromQuery] double b)
        => Ok(new { result = a - b });

    [HttpGet("multiply")]
    public IActionResult Multiply([FromQuery] double a, [FromQuery] double b)
        => Ok(new { result = a * b });

    [HttpGet("divide")]
    public IActionResult Divide([FromQuery] double a, [FromQuery] double b)
    {
        if (b == 0) return BadRequest(new { error = "Division by zero is not allowed." });
        return Ok(new { result = a / b });
    }
}