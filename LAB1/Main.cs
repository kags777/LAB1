using LAB1;
class App
{
    static void Main()
    {

        int a = 0;//вспомогательная переменная
        int number; // еще одна вспомогательная переменная
        int Choice;

        List<BaseVehicle> vehicles = new List<BaseVehicle>();
        Manager manager = new Manager();

        do
        {
            do
            {
                Console.WriteLine("\nSelect the desired operation");
                Console.WriteLine("\nMenu:\n");
                Console.WriteLine("1. Add vehicle\n");
                Console.WriteLine("2. Print vehicles\n");
                Console.WriteLine("3. Exit\n");
                string choice = Console.ReadLine();
                Manager.TryParseNumber(choice, out Choice);


            } while (false);


            switch (Choice)
            {
                case 1:
                    manager.AddObject(vehicles);
                    break;
                case 2:
                    manager.printVehicles(vehicles);
                    break;
                case 3:
                    Console.WriteLine("До свидания!");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice.\n");
                    break;
            }
        } while (Choice != 3);
    }
}



