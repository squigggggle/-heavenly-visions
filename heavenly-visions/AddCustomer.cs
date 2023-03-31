using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heavenly_visions
{
    public class AddCustomer
    {
        private string userName;
        private string tourSelection;
        
     
     public AddCustomer(string userName, string tourSelection) 
        {

        this.userName = userName;
        this.tourSelection = tourSelection;
        
        }

        public string UserName { get => userName; set => userName = value; }
        public string TourSelection { get => tourSelection; set => tourSelection = value; }
        

        public static void addDetails(int tourID, string name, Map people)
        {
            people.Add(tourID, name);
        }

        public static void viewTour(Map people)
        {
            
            Console.WriteLine("First List" + people.Lookup(1));
            Console.WriteLine("Second List" + people.Lookup(2));
            Console.WriteLine("Third List" + people.Lookup(3));
            Console.ReadLine();
        }
    }
}