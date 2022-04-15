using Xunit;
using CalculateInterest.API.Services;

namespace backend.src.TestsCalculateInterest.ServicesTest {
    public class RateOfInterestServiceTest {
        [Fact]
        public void InterestValueTest() {
            RateOfInterestService rateOfInterest = new RateOfInterestService();
            var result = rateOfInterest.InterestValue();

            Assert.Equal(0.01M, result);
        }
    }
}