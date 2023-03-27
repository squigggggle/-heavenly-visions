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