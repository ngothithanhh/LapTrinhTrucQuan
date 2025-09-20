using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    public class Car : IVehicle
    {
        int fuel;
        public Car(int _fuel)
        {
            fuel = _fuel;
        }
        public void Drive()
        {
            if (this.fuel >= 0)
            {
                Console.WriteLine($"Xe dang di chuyen, xang hien tai: {fuel}");
                this.fuel-=3;
            }
            else
            {
                Console.WriteLine("Het xang.");
            }
        }
        public bool Refuel(int _fuel)
        {
            this.fuel += _fuel;
            return true;
        }
    }
}
