using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsSamples
{
    //alarm is a class representing Alarm to be set of every time the Door is Opened
    //on Any House...
    internal class Alarm
    {
        //now there are multiple houses...
        public List<House> Houses { get; set; }        

        public Alarm(List<House> houses)
        {
            this.Houses = houses;
           //register all the houses to Set the Alarm
           foreach(House house in Houses)
                house.DoorOpened += SetAlarm;


            
          
        }

        //now we need to know which house Set the alarm...
            public void SetAlarm(House h)
        {
            
            Console.Beep(350, 2000);
            Console.Beep(550, 1000);
            Console.WriteLine($"Alarm was SetOff on House number {h.houseNumber}");
            


        }
    }
}
