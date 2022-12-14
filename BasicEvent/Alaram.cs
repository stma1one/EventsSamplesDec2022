using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsSamples
{
    //alarm is a class representing Alarm to be set of every time the Door is Opened 
    
    internal class Alarm
    {
        House house;
        

        //constructur
        public Alarm(House house)
        {
            this.house = house;
            //when the delegate DoorOpened is Called-> SetAlarm() will be called
            this.house.DoorOpened += SetAlarm;

            
          
        }

        //makes 2 beeps and prints a message
            public void SetAlarm()
        {
            
            Console.Beep(350, 2000);
            Console.Beep(550, 1000);
            Console.WriteLine($"Alarm was SetOff on House number {this.house.houseNumber}");
            


        }
    }
}
