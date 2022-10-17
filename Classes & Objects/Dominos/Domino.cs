using System;
namespace Dominos
{
    public class Domino
    {
        private readonly int[] Values;

        public Domino(int valueA, int valueB)
        {
            this.Values = new int[] { valueA, valueB };
        }

        public int[] GetValues()
        {
            return Values;
        }

        public override string ToString()
        {
            return string.Format("[ {0}, {1} ] ", Values[0], Values[1]);
        }

        public int sumValues()
        {
            return Values[0] + Values[1];
        }
    }
}

