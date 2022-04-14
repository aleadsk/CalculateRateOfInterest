using CalculateInterest.API.Services;
using CalculateInterest.API.Services.CalculateInterestService;

namespace Tests {
    public class CalculateInterestServiceTest {
        [Fact]
        public void CalculateInterestServiceTest() {
            var result = CalculateInterestService.CalculateInterest(100, 5);

            result.Should().Be(105.10);
        }

        public void ShowMeTheCodeServiceTest() {
            //TODO
        }
    }
}