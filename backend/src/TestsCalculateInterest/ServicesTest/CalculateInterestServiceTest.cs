using Xunit;
using CalculateInterest.API.Services;

namespace backend.src.TestsCalculateInterest.ServicesTest {
    public class CalculateInterestServiceTest {
        CalculateInterestService calculate = new CalculateInterestService();

        [Fact]
        public void CalculateInterestTest() {
            decimal result = calculate.CalculateInterest(100, 5);

            Assert.Equal((decimal)105.10, result, 2);
        }
        
        [Fact]
        public void ShowMeTheCodeTest() {
            var result = calculate.ShowMeTheCode();

            Assert.Equal(result, "https://github.com/aleadsk/CalculateRateOfInterest");
        }
    }
}