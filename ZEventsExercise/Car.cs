using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZEventsExercise
{
    internal class Car
    {
        private Battery battery;
        public  string ModelName { get; set; }

        public int Km { get; set; }//  כמה מרחק עברה הרכב

        public Car( string modelName)
        {
            this.battery = new Battery();
            ModelName = modelName;
        }


        //drives until battery low.
        //prints the status of the battery 
        //each 500 ms adds 1 km to the total distance of the car
        //if battery low = prints a message to charge the car
        public void Drive()
        {
            while(this.battery.Percentage>0)
            {
                this.battery.UseBattery();
            }
        }

        //charges the battery until it's full.
         // writes a message each time the battery volume updates...
        public void Charge()
        { }
    }
}
