namespace mormorsButiken.Menus;

public class BrowesItemsMenu
{
    public TopsMenu TopMenu;
    public BottomsMenu BottomMenu;
    public AccMenu AccMenu;
    public BrowesItemsMenu(StartMenu startMenu)
    {
        TopMenu = new TopsMenu(startMenu);
        BottomMenu = new BottomsMenu();
        AccMenu = new AccMenu(startMenu);
    }
    
    public void Start()
    {
        bool run = true;
        while (run)
        {
            
            Console.WriteLine($"\n--- Browes Items ---" +
                              $"\n" +
                              $"\n1. Tops" +
                              $"\n2. Bottoms" +
                              $"\n3. Accessories" +
                              $"\nB. Back" +
                              $"\n" );
            
            String choice = Console.ReadLine();

            switch (choice.Trim().ToLower())
            {
                case "1":
                    TopMenu.Start();
                    break;
                
                case "2":
                    BottomMenu.Start();
                    break;
                
                case "b":
                    run = false;
                    break;
                
                case "3":
                    AccMenu.Start();
                    break;
                
                default:
                    Console.WriteLine("You need to pick 1 - 4.");
                    break;
            }
        }
    }
}