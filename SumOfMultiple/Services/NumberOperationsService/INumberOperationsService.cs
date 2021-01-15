namespace SumOfMultiple.Services.NumberOperationsService {
    public interface INumberOperationsService {

        /// <summary>
        /// Find the sum of all natural numbers that are a multiple
        /// of 3 or 5 below a limit provided as input.
        /// </summary>
        /// <param name="topLimit">The top limit specified by the user</param>
        /// <returns>
        /// The sum of all natural numbers that are a multiple
        /// of 3 or 5 below the limit specified.
        /// </returns>
        uint CalculateSumOfMultiple(uint topLimit);

        /// <summary>
        /// Checks whether <paramref name="x"/> is multiple of <paramref name="y"/>
        /// </summary>
        /// <returns>Whether <paramref name="x"/> is multiple of <paramref name="y"/></returns>
        bool IsMultipleOf(uint x, uint y);
    }
}
