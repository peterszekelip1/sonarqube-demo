using ClassLibrary1;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers;

[ApiController]
[Route("[controller]")]
public class CalculatorController : ControllerBase
{
    private readonly Calculator _calculator;

    public CalculatorController(Calculator calculator)
    {
        _calculator = calculator;
    }

    [HttpGet(Name = "add")]
    public IActionResult Add([FromQuery] int a, [FromQuery] int b)
    {
        var result = _calculator.Add(a, b);
        
        return Ok(result);
    }
}
