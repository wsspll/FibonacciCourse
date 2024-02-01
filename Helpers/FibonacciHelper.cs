using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci.Helpers
{
    public static class FibonacciHelper
    {

        // Генерация последовательности Фибоначчи на основе заданного начального массива.
        public static int[] GenerateFibonacciSequence(int[] seed, int n, int j, int k)
        {
            List<int> sequence = seed.ToList();

            if (sequence.Count < k)
            {
                throw new ArgumentException("Введенная последовательность чисел должна быть больше, чем k");
            }

            if (j > k) 
            {
                throw new ArgumentException("k должен быть больше, чем j");
            }



            for (int i = 0; i < n; i++)
            {
                int nextValue = (sequence[sequence.Count - j] + sequence[sequence.Count - k]) % 1000;
                sequence.Add(nextValue);
            }

            return sequence.ToArray();
        }
    }
}
