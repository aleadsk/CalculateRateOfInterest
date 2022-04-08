using CalculateInterest.API.Model.Interface;
using Microsoft.AspNetCore.Mvc;

namespace CalculateInterest.API.Controllers {
    [ApiController]
    [Route("api/[controller]")]
    public class RateOfInterestController : ControllerBase {
        private readonly IRateOfInterest _rateInterestService;
        public RateOfInterestController(IRateOfInterest rateInterestService) {
            _rateInterestService = rateInterestService;
        }
        
        [HttpGet("taxadejuros")]
        public IActionResult CalculateInterest() {
            var result = _rateInterestService.InterestValue();

            return Ok($"A taxa de juros é: {result}");
        }
    }
}