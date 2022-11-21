using System;
namespace PetrolStation
{
    public class Station
    {
        public int gasAmount = 0;

        public Station(int _gasAmount)
        {
            this.gasAmount = _gasAmount;
        }

        public void ReFill(Car _car)
        {
            _car.gasAmount += 100;
            this.gasAmount -= 100;
        }
    }
}

