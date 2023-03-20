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
            string userinput = "";
            Console.WriteLine("Please enter your first name");
            userinput= Console.ReadLine();
            Console.WriteLine("Hello " + userinput );


        }
            

    }
}