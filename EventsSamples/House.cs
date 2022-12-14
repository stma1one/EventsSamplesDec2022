using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsSamples
{
    //מידע על מה קרה באירוע
    public class HouseEventsArgs:EventArgs
    {
        public DateTime eventTime { get; set; }
    }


   //replace by EventHandler<>
   // public  delegate void HouseEvents (object c, HouseEventsArgs args);
    internal class House
    {
        private bool doorOpen;
       public int houseNumber { get; set; }
        public string phone { get; set; }
        //שימוש בגנריות מאפשר לשלוח טיפוס של המידע על האירוע ללא צורך בהמרה
        public event EventHandler<HouseEventsArgs> DoorOpened;

        public House(int houseNumber )
        {
            this.houseNumber = houseNumber;
            doorOpen = false;
        }
        public void OpenDoor()
        {
            Thread.Sleep(2000);
            doorOpen = true;
            OnOpenDoor();


        }
        private void OnOpenDoor()
        {
            DoorOpened?.Invoke(this,new HouseEventsArgs() { eventTime=DateTime.Now});
        }
    }
}
