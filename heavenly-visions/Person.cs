using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heavenly_visions
{
    public class Person
    {
        private string name;
        private int tourID;

        public Person(string name, int tourID)
        {
            this.name = name;
            this.tourID = tourID;
        }

        public string Name { get => name; set => name = value; }
        public int TourID { get => tourID; set => tourID = value; }

        public string UserInput() 
        {
            bool loop;
            do 
            {
                Console.Write("Please enter the full name e.g.(John Smith): ");
                name = Console.ReadLine();
                Console.WriteLine("Person added!\n");
                Console.WriteLine($"What tour is {name} on? e.g.(1 or 2...): ");
                tourID = Convert.ToInt32(Console.ReadLine());
                AddCustomer.addName(name);
                AddCustomer.addTour(tourID);
                Console.WriteLine("Would you like to add another person? [yes | no]");
                string check = Console.ReadLine().ToLower();
                if (check == "yes")
                {
                    loop = true;
                }
                else
                { 
                    loop = false;
                }

            } while (loop);
            return name + tourID;
        }
    }
}
