using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heavenly_visions
{
    public class AddCustomer
    {
        private string firstName;
        private string lastName;

     
     public AddCustomer(string firstName, string lastName) 
        {

        this.firstName = firstName;
        this.lastName = lastName;
        
        }

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }

        public static void addName()
        {
            bool loop;
            List<string> peopleAdd = new List<string>();
            do
            {
                Console.Write("Please enter the full name e.g.(John Smith): ");
                peopleAdd.Add(Console.ReadLine());
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