using System.Xml.Linq;

namespace heavenly_visions
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] Tour1 = new string[10];
            string[] Tour2 = new string[10];
            string[] Tour3 = new string[10];
            Map people = new Map();
            int mainMenu;

            do
            {
                Console.Clear();
                Console.WriteLine("1: Enter User\n2: View Users\n0: Exit");
                mainMenu = Convert.ToInt32(Console.ReadLine());
                switch(mainMenu)
                {
                    case 0:
                        //exit
                        Console.WriteLine("Goodbye");
                        break;
                    case 1:


                        //enter user
                        string name;
                        int tourID;
                        bool loop;
                        
                        do
                        {
                            Console.Write("Please enter the full name e.g.(John Smith): ");
                            name = Console.ReadLine();
                            Console.WriteLine("Person added!\n");
                            Console.WriteLine($"What tour is {name} on? e.g.(1 or 2...): ");
                            tourID = Convert.ToInt32(Console.ReadLine());
                            Person person = new Person(name, tourID);
                            person.UserInput();
                            AddCustomer.addDetails(tourID, name, people);
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
                        

                        break;
                    case 2:
                        //view tours
                        AddCustomer.viewTour(people);
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Invalid option, try again.");
                        Console.ReadLine();
                        break;
                }
            } while (mainMenu != 0);

           
        }
    }
}