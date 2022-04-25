using ClassLibrary1;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers;

[ApiController]
[Route("[controller]")]
public class CalculatorController : ControllerBase
{
    private readonly Calculator _calculator;
    public CalculatorController()
    {
        _calculator = new Calculator();
    }

    [HttpGet("add")]
    public IActionResult Add(int a, int b)
    {
        var result = _calculator.Add(a, b);
        return Ok(result);
    }

    [HttpGet("substract")]
    public IActionResult Subtract(int a, int b)
    {
        var result = _calculator.Subtract(a, b);
        return Ok(result);
    }

    [HttpGet("divide")]
    public IActionResult Divide (int a, int b)
    {
        var result = _calculator.Divide(a, b);
        return Ok(result);
    }

    [HttpGet("Multiply")]
    public IActionResult Multiply(int a, int b)
    {
        var result = _calculator.Multiply(a, b);
        return Ok(result);
    }

    [HttpGet("Power")]
    public IActionResult Power(int a, int b)
    {
        var result = _calculator.Power(a, b);
        return Ok(result);
    }
}
