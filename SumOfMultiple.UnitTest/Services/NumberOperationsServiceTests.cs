using SumOfMultiple.Services.NumberOperationsService;

using Xunit;

namespace SumOfMultiple.Services.Tests {
    public class NumberOperationsServiceTests {

        private readonly INumberOperationsService numberOperationsService;

        public NumberOperationsServiceTests() {
            numberOperationsService = new NumberOperationsService.NumberOperationsService();
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(18, 60)]
        [InlineData(19, 78)]
        [InlineData(20, 78)]
        public void CalculateSumOfMultiple(uint topLimit, uint expectedResult) {
            var actualResult = numberOperationsService.CalculateSumOfMultiple(topLimit);

            Assert.Equal(expectedResult, actualResult);
        }

        [Theory]
        [InlineData(10, 5, true)]
        [InlineData(10, 6, false)]
        [InlineData(0, 0, false)]
        [InlineData(1, 0, false)]
        [InlineData(0, 1, true)]
        public void IsMultipleOf(uint x, uint y, bool expectedResult) {
            var actualResult = numberOperationsService.IsMultipleOf(x, y);

            Assert.Equal(expectedResult, actualResult);
        }
    }
}