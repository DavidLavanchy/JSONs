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

            Console.WriteLine(json);
            Console.ReadKey();
        }
    }
}
