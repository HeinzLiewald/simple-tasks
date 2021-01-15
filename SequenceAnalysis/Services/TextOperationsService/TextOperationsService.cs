using System.Linq;

namespace SequenceAnalysis.Services.TextOperationsService {
    public class TextOperationsService : ITextOperationsService {

        /// <inheritdoc/>
        public string GetUppercaseSequenceAnalysis(string input) {
            if(string.IsNullOrWhiteSpace(input)) {
                return string.Empty;
            }

            var uppercaseWords = string.Empty;

            foreach(var word in input.Split()) {
                if(IsUppercase(word)) {
                    uppercaseWords += word;
                }
            }

            var uppercaseCharactersAlphabetically = uppercaseWords.OrderBy(x => x);

            return string.Join(string.Empty, uppercaseCharactersAlphabetically);
        }

        /// <inheritdoc/>
        public bool IsUppercase(string word) {
            if(string.IsNullOrWhiteSpace(word)) {
                return false;
            }

            return !word
                        .Trim()
                        .Any(character => character < 'A' || character > 'Z');
        }
    }
}
