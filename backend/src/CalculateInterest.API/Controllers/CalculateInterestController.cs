using CalculateInterest.API.Model.Interface;
using Microsoft.AspNetCore.Mvc;

namespace CalculateInterest.API.Controllers {
    [ApiController]
    [Route("api/[controller]")]
    public class CalculateInterestController : ControllerBase {
        
        private readonly ICalculateInterest _calculateInterestService;
        public CalculateInterestController(ICalculateInterest calculateInterestService) {
            _calculateInterestService = calculateInterestService;
        }

        [HttpGet("calculajuros/{initialValue}/{timeInMonth}")]
        public IActionResult CalculateInterest(decimal initialValue, int timeInMonth) {
            var result = _calculateInterestService.CalculateInterest(initialValue, timeInMonth);

            return Ok($"Calculo Realizado: {result}");
        }

        [HttpGet("Showmethecode")]
        public IActionResult ShowMeTheCode(){
            string url = _calculateInterestService.ShowMeTheCode();

            return Ok($"Link do GitHub: {url}");
        }
    }
}