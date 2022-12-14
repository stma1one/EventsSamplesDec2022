using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsSamples
{
    
    


   //אנחנו צריכים כדי שנוכל להפעיל פעולות
   //נשנה את החתימה של הפעולה לקבל את הבית
    public  delegate void HouseEvents (House h);
    public class House
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
            //מכיון שחתימה דורשת את הבית שבו נפתחה הדלת נשלח
            //את הבית הנוכחי - this
            DoorOpened?.Invoke(this);
        }
    }
}
