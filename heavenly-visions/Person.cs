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
        public static void UserInput() 
        {
            bool loop;
            List<string> people = new List<string>();
            do 
            {
                Console.Write("Please enter the full name e.g.(John Smith): ");
                people.Add(Console.ReadLine());
                Console.WriteLine("Person added!\n");
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
            

        }
    }
}
