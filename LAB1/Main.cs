using LAB1;
class Main
{
    int a = 0;//вспомогательная переменная
    int number; // еще одна вспомогательная переменная

do{
    do{
        Console.WriteLine("Select the desired operation");
        Console.WriteLine("\nMenu:\n");
        Console.WriteLine("1. Add vehicle\n");
        Console.WriteLine("2. Print vehicles\n");
        Console.WriteLine("3. Exit\n");
        string choice = Console.ReadLine();

        if (int.TryParse(choice, out number))
        {
            a = 1;
        }

        else
{
    Console.WriteLine("Ошибка: это не число!");
}
    } while (a != 1) ;


switch (number)
{
    case 1:
        addObject(vehicles);
        break;
    case 2:
        printVehicles(vehicles);
        break;
    case 3:
        return 0;
    default:
        Console.WriteLine("Invalid choice.\n");
        break;
}

} while (true) ;


