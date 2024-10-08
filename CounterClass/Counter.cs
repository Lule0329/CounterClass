using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterClass
{
    internal class Counter
    {
         int counter = 0;
        const int MaxCount = 10;

        public Counter(int start)
        {
            counter += start;
        }
        
        // Ökar räknaren med ett
        public void Increment()
        {
            counter++;
            ReachedMaxCount();
        }

        // Ökar räknaren med ett visst tal
        public void IncrementBy(int increment)
        {
            counter += increment;
            ReachedMaxCount();
        }

        // Återställer räknaren
        public void Reset()
        {
            counter = 0;
        }

        // ger värdet på räknaren
        public int GetValue()
        {
            return counter;
        }

        public void ReachedMaxCount()
        {
            if (counter > MaxCount)
            {
                counter = 0;
            }
        }
    }
}
