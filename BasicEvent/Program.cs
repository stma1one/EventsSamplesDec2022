using EventsSamples;

namespace BasicEvent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            House annaZak = new House(4) { phone = "0525381648" };
            Alarm alarm = new Alarm(annaZak);
            annaZak.OpenDoor();
           
        }
    }
}