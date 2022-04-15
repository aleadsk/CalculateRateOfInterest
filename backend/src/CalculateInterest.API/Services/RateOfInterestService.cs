using CalculateInterest.API.Model.Interface;

namespace CalculateInterest.API.Services {
    public class RateOfInterestService : IRateOfInterest {
        public decimal InterestValue() {
            return 0.01M;
        }
    }
}