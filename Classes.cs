using System.Data;
using Auth0;
using Auth0_Blazor;

namespace Auth0_Blazor
{
    enum RoomType
    {
        Kitchen,
        LivingRoom,
        Bedroom,
        Bathroom,
        Garage,
        Basement,
        Attic,
        Office,
        Exterior,
        Other
    }   

    enum housingStyle
    {
        Farmhouse,
        Craftsman,
        Mediterranean,
        CapeCod,
        Colonial,
        MidCentury,
        Other
    }

    public class siteProfile
    {
        public siteProfile()
        {
            username = "";
            house = new House();
        }
        public string username;
        public House house { get; set; }
    }

    public class House
    {
        public House()
        {
            roomList = new List<Room>();
            name = "";
        }
        public string name;
        public List<Room> roomList { get; set; }

    }

    public class Room
    {
        public Room()
        {
            name = "";
            applianceList = new List<Appliance>();
        }   
        public string name;
        public List<Appliance> applianceList { get; set; }
    }

    public class Appliance
    {
        public Appliance()
        {
            name = "";
            repairTimers = new List<appTimer>();
        }

        public string name;
        public List<appTimer> repairTimers { get; set; }

    }

    public class appTimer
    {
        public appTimer()
        {
            name = "";
            lastDone = new DateTime(0, 0, 0);
            interval = 0;
            nextDue = lastDone.AddDays(interval);
        }

        public appTimer(string timername, DateTime last, double i)
        {
            name = timername;
            lastDone = last;
            interval = i;
            nextDue = lastDone.AddDays(interval);
        }

        public void update()
        {
            DateTime temp = lastDone;
            lastDone = nextDue;
            nextDue = temp.AddDays(interval);
        }

        private DateTime lastDone;
        public double interval;
        public DateTime nextDue;
        public string name;


    }
}
