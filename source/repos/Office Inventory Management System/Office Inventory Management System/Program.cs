using System;
using System.Collections.Generic;
using System.Security.Claims;

public class InventoryManagement
{
    public static void Main(string[] args)
    {
        // Your code goes here
        List<string> inventoryList = new List<string>
        {
            "Printer",
            "Laptop",
            "Desk Chair",
            "Monitor",
            "Keyboard"
        };
        Console.WriteLine(inventoryList.Count);
        Console.WriteLine(inventoryList.Contains("Desk Chair"));
        Console.WriteLine(inventoryList.Remove("Printer"));
        foreach (var items in inventoryList)
        {
            Console.WriteLine(items);

        }
        List<string> newItems = new List<string> { "Mouse", "Desk Lamp" };
        inventoryList.AddRange(newItems);
        inventoryList.RemoveRange(5,2);
        // Correct
        List<string> topInventory = inventoryList.GetRange(0, 3);
        foreach (var item in topInventory)
        {
            Console.WriteLine(item);
        }
    }
}