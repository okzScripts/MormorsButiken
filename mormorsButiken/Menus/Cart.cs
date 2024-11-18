namespace mormorsButiken.Menus;

public class Cart
{
    public StartMenu _startMenu;

    public List<StockItem> cartItems = new List<StockItem>();

    public Cart(StartMenu startMenu)
    {
        _startMenu = startMenu;
    }
}