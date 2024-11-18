﻿using System.Diagnostics;
using mormorsButiken.Items;
using mormorsButiken.Items.Accessories.Belt;
using mormorsButiken.Items.Accessories.Gloves;
using mormorsButiken.Items.Cloths;
using mormorsButiken.Items.Cloths.Tops;
using mormorsButiken.Items.Cloths.Tops.Hoodies;

namespace mormorsButiken.Menus;

public class StartMenu
{
    BrowesItemsMenu BIMenu;
    List<StockItem> StoreInventory = new List<StockItem>();

    public StartMenu()
    {
        BIMenu = new BrowesItemsMenu(this);
        populateStoreInventory();
        printStoreInventory();
    }

    public void Start()
    { 
        bool run = true;
        while (run)
        {
            
            Console.WriteLine($"\n--- Start Menu ---" +
                              $"\n" +
                              $"\n1. Browes Items" +
                              $"\n2. Cart" +
                              $"\n3. Login" +
                              $"\n4. Quit" +
                              $"\n" );
            
            String choice = Console.ReadLine();

            switch (choice.Trim())
            {
                case "1":
                    BIMenu.Start();
                    break;
                
                case "2":
                    Console.WriteLine("Cart - WIP");
                    break;
                
                case "3":
                    Console.WriteLine("Login - WIP");
                    break;
                
                case "4":
                    Console.WriteLine("Programmet avslutas!");
                    run = false;
                    break;
                
                default:
                    Console.WriteLine("You need to pick 1 - 4.");
                    break;
            }
        }
    }

    private void populateStoreInventory()
    {
        StoreInventory.Add(new StockItem(
            new Belt(200, "Skin bälte", "Brun", BeltSize.Cm80 )
            , 5));
        StoreInventory.Add(new StockItem(
            new Belt(200, "Skin bälte", "Brun", BeltSize.Cm85 )
            , 5));
        StoreInventory.Add(new StockItem(
            new Belt(200, "Skin bälte", "Brun", BeltSize.Cm90 )
            , 5));
        
        StoreInventory.Add(new StockItem(
            new Belt(200, "Skin bälte", "Svart", BeltSize.Cm90 )
            , 5));
        StoreInventory.Add(new StockItem(
            new Belt(200, "Skin bälte", "Svart", BeltSize.Cm100 )
            , 5));
        StoreInventory.Add(new StockItem(
            new Belt(200, "Skin bälte", "Svart", BeltSize.Cm105 )
            , 5));
        
        StoreInventory.Add(new StockItem(
            new Belt(200, "Skin bälte", "Ljus Brun", BeltSize.Cm90 )
            , 5));
        StoreInventory.Add(new StockItem(
            new Belt(200, "Skin bälte", "Ljus Brun", BeltSize.Cm100 )
            , 5));
        StoreInventory.Add(new StockItem(
            new Belt(200, "Skin bälte", "Ljus Brun", BeltSize.Cm105)
            , 5));
        StoreInventory.Add(new StockItem(
            new Hoodie(450,"White Hoody","White",FitSize.Loose,TopSize.M)
        ,3));
        StoreInventory.Add(new StockItem(
            new Gloves(259,"Leather Gloves", "Black",GloveSize.S_M),5));
    }

    public void printStoreInventory()
    {
        foreach (var stockItem in StoreInventory)
        {
            Console.WriteLine($"{stockItem.Product.Name} - {stockItem.Product.Color} - {stockItem.Product.Price} -  {stockItem.Quantity}");
        }
        
    }

    public List<StockItem> GetItems()
    {
        return StoreInventory;
    }
}