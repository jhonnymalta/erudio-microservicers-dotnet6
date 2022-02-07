using Microsoft.AspNetCore.Mvc;

namespace IntroducaoRest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {
       
  

        private readonly ILogger<CalculatorController> _logger;

        public CalculatorController(ILogger<CalculatorController> logger)
        {
            _logger = logger;
        }

        [HttpGet("sum/{firstNumber}/{secondNumber}")]
        public IActionResult Sum(string firstNumber, string secondNumber)
        {
            if(IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var sum =  Convert.ToDecimal(firstNumber) + Convert.ToDecimal(secondNumber);
                return Ok(sum.ToString());
            }
           return BadRequest("Invalid Input");
        }


        [HttpGet("subtract/{firstNumber}/{secondNumber}")]
        public IActionResult Subtract(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var subtract = Convert.ToDecimal(firstNumber) - Convert.ToDecimal(secondNumber);
                return Ok(subtract.ToString());
            }
            return BadRequest("Invalid Input");
        }
        // Divisao
        [HttpGet("divide/{firstNumber}/{secondNumber}")]
        public IActionResult Divide(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var divide = Convert.ToDecimal(firstNumber) / Convert.ToDecimal(secondNumber);
                return Ok(divide.ToString());
            }
            return BadRequest("Invalid Input");
        }

        //multiplicacao
        [HttpGet("multiplication/{firstNumber}/{secondNumber}")]
        public IActionResult Mult(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var mult = Convert.ToDecimal(firstNumber) * Convert.ToDecimal(secondNumber);
                return Ok(mult.ToString());
            }
            return BadRequest("Invalid Input");
        }

        private bool IsNumeric(string strNumber)
        {
            double number;
            bool isNumber  = double.TryParse(strNumber, System.Globalization.NumberStyles.Any,System.Globalization.NumberFormatInfo.InvariantInfo, out number);
            return isNumber;
           
        }
    }
}