using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kata1
{
    public class MultiplesCalculator
    {
        public int Calculate(int firstMultiple, int secondMultiple, int total)
        {
            var numbers = new HashSet<int>();

            for (int a = firstMultiple; a < total; a += firstMultiple)
                numbers.Add(a);

            for (int b = secondMultiple; b < total; b += secondMultiple)
                numbers.Add(b);

            return numbers.Sum();
        }
    }
}
