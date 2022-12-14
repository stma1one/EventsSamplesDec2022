using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsSamples
{

    //ניצור אובייקט שבו נשמור את המידע על מה שקרה בזמן האירוע
    public class DoorEventsArgs
    {
        public DateTime eventTime { get; set; }
    }


    //אנחנו צריכים כדי שנוכל להפעיל פעולות
    //נשנה את החתימה של הפעולה לקבל את הבית
    //public  delegate void HouseEvents (House h);

    //נהפוך את זה ליותר כללי שיוכל לשרת לנו גם חנויות וטיפוסים נוספים
    //לכל דבר שיש בו דלת שניתן לפתוח אותה

    //נוסיף לחתימה את האובייקט שיכיל את נתוני האירוע
    public delegate void DoorEvents(object sender, DoorEventsArgs args);
    public class House
    {
        private bool doorOpen;
       public int houseNumber { get; set; }
        public string phone { get; set; }
       public  DoorEvents DoorOpened;

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
            //כאשר האירוע קרה, נשמור את פרטי האירוע באובייקט הייעודי
            DoorOpened?.Invoke(this,new DoorEventsArgs() { eventTime=DateTime.Now});
        }
    }
}
