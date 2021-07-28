using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            person.FirstName = "David";
            person.LastName = "Lavanchy";
            person.DOB = new DateTime(1998, 04, 07);

            string json = JsonConvert.SerializeObject(person);

            Event newEvent = new Event();

            newEvent.StartDate = new DateTime(2021, 07, 27);
            newEvent.EndDate = new DateTime(2021, 07, 31);
            newEvent.EventTitle = "Gen Con";
            newEvent.EventCapacity = 10000;
            newEvent.PriceOfAdmission = 325.50m;

            string json2 = JsonConvert.SerializeObject(newEvent);

            Badge newBadge = new Badge();

            newBadge.BadgeID = 12345;
            newBadge.ListOfDoors = new List<string>{ "A1", "B2", "B5", "G21"};
            newBadge.HasSecurityClearance = true;
            newBadge.EmployeeID = "F54G678HJ32321S";
            newBadge.CreatedOn = new DateTime(2021, 07, 27);

            string json3 = JsonConvert.SerializeObject(newBadge);

            Console.WriteLine(json);
            Console.WriteLine(json2);
            Console.WriteLine(json3);

            Console.ReadKey();
        }
    }
}
