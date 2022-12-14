using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsSamples
{
    internal class Shops
    {
        private bool doorOpen;
        public int houseNumber { get; set; }
        private string phone;
        public event EventHandler<HouseEventsArgs> DoorOpened;

        public Shops(int houseNumber)
        {
            this.houseNumber = houseNumber;
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
