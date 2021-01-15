using SequenceAnalysis.Services.TextOperationsService;

using Xunit;

namespace SequenceAnalysis.Services.Tests {
    public class TextOperationsServiceTests {

        private readonly ITextOperationsService textOperationsService;

        public TextOperationsServiceTests() {
            textOperationsService = new TextOperationsService.TextOperationsService();
        }

        [Theory()]
        [InlineData("This IS a STRING", "GIINRSST")]
        [InlineData("This IS a STRING 123", "GIINRSST")]
        [InlineData("This 123IS a STRING 123", "GINRST")]
        [InlineData(" This IS a STRING", "GIINRSST")]
        [InlineData("This IS a STRING ", "GIINRSST")]
        [InlineData(" This IS a STRING ", "GIINRSST")]
        [InlineData(null, "")]
        [InlineData("", "")]
        [InlineData(" ", "")]
        [InlineData("123", "")]
        [InlineData(" ... ", "")]
        [InlineData("Abc d ef ghI", "")]
        [InlineData(" Abc d ef ghI ", "")]
        public void GetUppercaseSequenceAnalysis(string input, string expectedResult) {
            var actualResult = textOperationsService.GetUppercaseSequenceAnalysis(input);

            Assert.Equal(expectedResult, actualResult);
        }

        [Theory()]
        [InlineData("Abc", false)]
        [InlineData(" Abc ", false)]
        [InlineData("ABC", true)]
        [InlineData(" ABC ", true)]
        [InlineData(" ABC D ", false)]
        [InlineData(" ", false)]
        [InlineData("", false)]
        [InlineData(null, false)]
        public void IsUppercase(string input, bool expectedResult) {
            var actualResult = textOperationsService.IsUppercase(input);

            Assert.Equal(expectedResult, actualResult);
        }
    }
}