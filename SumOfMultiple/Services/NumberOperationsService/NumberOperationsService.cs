namespace SumOfMultiple.Services.NumberOperationsService {
    public class NumberOperationsService : INumberOperationsService {

        /// <inheritdoc/>
        public uint CalculateSumOfMultiple(uint topLimit) {
            uint result = 0;

            for(uint i = 3; i < topLimit; i++) {
                if(IsMultipleOf(i, 3) || IsMultipleOf(i, 5)) {
                    result += i;
                }
            }

            return result;
        }

        /// <inheritdoc/>
        public bool IsMultipleOf(uint x, uint y) {
            if(0 == y) {
                return false;
            }

            return 0 == x % y;
        }
    }
}
