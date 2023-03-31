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
            int mainMenu;

            do
            {
                Console.Clear();
                Console.WriteLine("sample text");
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
                        

                        break;
                    case 2:
                        //view tours
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