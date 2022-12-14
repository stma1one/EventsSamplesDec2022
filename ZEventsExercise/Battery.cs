using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZEventsExercise
{
    //add EVENTS, EventArgs as needed, and methods as needed
    //to support: events: Battary Low (under 20%) , BatteryCharging (Updates the current state of the battery)
    // BatteryInUse (notify each time the battery in use and current state of the battery.)
    internal class Battery
    {
        private  const int CAPACITY = 5000;

        private int currentVolume;//כמה כרגע טעון
        public double Percentage { get => currentVolume / 100.0; }

        public Battery()
        {
            currentVolume = 0;
        }

        public void Charge()
        {
            Thread.Sleep(1000);
            currentVolume += 10;
        }

        public void UseBattery()
        {
            Thread.Sleep(1000);
            currentVolume -= 10;
        }
    }
}
