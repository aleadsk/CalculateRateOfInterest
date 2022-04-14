using CalculateInterest.API.Services;

namespace Tests {
    public static class RateOfInterestServiceTest {
        public static void InterestValueTest() {
            var result = RateOfInterestService.InterestValue();

            result.Should.Be(0.01M);
        }
    }
}