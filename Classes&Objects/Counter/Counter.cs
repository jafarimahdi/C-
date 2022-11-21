using System;
namespace Counter
{
    public class Counter
    {
        int counter = 0;

        public Counter(int _counter)
        {
            counter = _counter;
        }

        public int Add()
        {
            counter++;
            return counter;

        }
        public int Add(int userNumber)
        {
            counter += userNumber;
            return counter;
        }
        public int Get()
        {
            return counter;
        }
        public void Reset()
        {
            counter = 0;
        }
    }
}

