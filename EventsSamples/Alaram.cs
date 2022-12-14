using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsSamples
{
    internal class Alarm
    {
       public  List<House> Houses;
        List<Shops> shops;

        public Alarm(List<House> houses,List<Shops> shops)
        {
            this.Houses = houses;
            this.shops = shops;
            foreach(var h in Houses)
            {
                h.DoorOpened += SetAlarm;
            }
            foreach (var s in shops)
            {
                s.DoorOpened += SetAlarm;
            }
        }

            public void SetAlarm(object sender,HouseEventsArgs args)
        {
            House house;
            Shops shop;
            Console.Beep(350, 2000);
            Console.Beep(550, 1000);
            if (sender is House)
            {
                house = (House)sender;
                Console.WriteLine($"House number {house.houseNumber} Set the Alarm and call {house.phone} door opened {args.eventTime}");
            }
            if(sender is Shops)
            {
                shop = (Shops)sender;
                Console.WriteLine($"House number {shop.houseNumber} Set the Alarm");
            }



            }
    }
}
