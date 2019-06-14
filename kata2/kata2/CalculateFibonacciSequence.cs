using System;

namespace kata2
{
    public class CalculateFibonacciSequence
    {
        public int Calculate(int length)
        {
            var total = 0;
            var currentNumber = 2;
            var previousNumber = 1;

            while (currentNumber <= length)
            {
                if (currentNumber % 2 == 0)
                    total += currentNumber;

                int value = currentNumber;
                currentNumber += previousNumber;
                previousNumber = value;
            }

            return total;
        }
    }
}
