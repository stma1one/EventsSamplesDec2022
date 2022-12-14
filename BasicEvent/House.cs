using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsSamples
{
    
    


   //אנחנו צריכים כדי שנוכל להפעיל פעולות
    public  delegate void HouseEvents ();
    internal class House
    {
        private bool doorOpen;
       public int houseNumber { get; set; }
        public string phone { get; set; }
       public  HouseEvents DoorOpened;

        public House(int houseNumber )
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
            DoorOpened?.Invoke();
        }
    }
}
