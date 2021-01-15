namespace SequenceAnalysis.Services.TextOperationsService {
    public interface ITextOperationsService {

        /// <summary>
        /// Find the uppercase words in a string, provided as input,
        /// and order all characters in these words alphabetically.
        /// </summary>
        /// <param name="input">The string to be processed</param>
        /// <returns>All the characters in these words ordered alphabetically.</returns>
        string GetUppercaseSequenceAnalysis(string input);

        /// <summary>
        /// Trims <paramref name="word"/> and checks if it's uppercase
        /// </summary>
        /// <param name="word">The word to be processed</param>
        /// <returns>Whether each character in <paramref name="word"/> is uppercase (Trimming from both sides)</returns>
        bool IsUppercase(string word);
    }
}
