using System;
public class VendingMachine
{
    private IMenu _menuLoader;
    public VendingMachine(IMenu menuLoader)
    {
        _menuLoader = menuLoader;
    }
    public void SayHello()
    {
        Console.WriteLine("Please Enter Your Name..");
        var userName = Console.ReadLine();
        Console.WriteLine($"Hello {userName} ! How Are You ? \n ");

    }

    public void TellTime()
    {
        var currentDate = DateTime.Now;
        Console.WriteLine($"Current time is {currentDate:d} at {currentDate:t}! \n");
    }

    public void DisplayMenu()
    {
        var products = _menuLoader.LoadMenu();
        //show menu
        foreach (var product in products)
        {
            Console.WriteLine(product.ToString());
        }
    }

    public void SayBye()
    {

        Console.WriteLine($"Press Any Key To Exit..");
        Console.ReadKey(true);

    }

    public void Start()
    {
        SayHello();

        TellTime();

        DisplayMenu();

        SayBye();
    }

}