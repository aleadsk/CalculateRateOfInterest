using System;
using CalculateInterest.API.Model.Interface;

namespace CalculateInterest.API.Services {
    public class CalculateInterestService : ICalculateInterest {

        private readonly IRateOfInterest _rateOfInterest;
        public CalculateInterestService(IRateOfInterest rateOfInterest){
            _rateOfInterest = rateOfInterest;
        }

        public decimal CalculateInterest(decimal initialValue, int timeInMonth) {
            var plus = 1 + _rateOfInterest.InterestValue();
            var exponential = Math.Pow(Convert.ToDouble(plus), Convert.ToDouble(timeInMonth));
            var calculate = Decimal.Multiply(initialValue,  Convert.ToDecimal(exponential));

            return Math.Round(calculate, 2);
        }

        public string ShowMeTheCode() {
            return "https://github.com/aleadsk/CalculateRateOfInterest";
        }
    }
}