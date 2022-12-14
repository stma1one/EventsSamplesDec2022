using EventsSamples;
using static System.Formats.Asn1.AsnWriter;

namespace EventsOnListWithArgs3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            House annaZak = new House(4) { phone = "0525381648" };
            House talsi = new House(16) { phone = "052333344" };
            List<House> houses = new List<House>();
            houses.Add(annaZak);
            houses.Add(talsi);
            Alarm alarm = new Alarm(houses);


            annaZak.OpenDoor();
            talsi.OpenDoor();
        }
    }
}