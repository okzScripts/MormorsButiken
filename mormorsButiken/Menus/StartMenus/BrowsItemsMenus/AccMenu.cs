using mormorsButiken.Items.Accessories;

namespace mormorsButiken.Menus;

public class AccMenu
{
    public StartMenu _startMenu;

    public AccMenu(StartMenu startMenu)
    {
        _startMenu = startMenu;
    }

    public void Start()
    {
        bool run = true;
        while (run)
        {
            
            Console.WriteLine($"\n--- Accessories ---" +
                              $"\n" +
                              $"\n1. Items" +
                              $"\nB. Back" +
                              $"\n" );
            
            String choice = Console.ReadLine();

            switch (choice.Trim().ToLower())
            {
                case "1":
                    Console.WriteLine("Items - WIP");
                    var tops = _startMenu.GetItems().Where(item => item.Product is Accessorie);
                    foreach (var item in tops)
                    {
                        Console.WriteLine($"{item.Product.Name} - {item.Product.Color} - {item.Product.Price} - {item.Quantity}");
                    }
                    break;
                
                case "b":
                    run = false;
                    break;
                
                default:
                    Console.WriteLine("You need to pick 1 - 4.");
                    break;
            }
        }
    }
}