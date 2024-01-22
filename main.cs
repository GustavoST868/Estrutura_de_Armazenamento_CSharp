using System;
using System.Collections.Generic;

// Store data in general
class Store
{
    // Attributes
    public List<string> data = new List<string>();

    // Constructor
    public Store() { }

    // Add value
    public void Add(string item)
    {
        data.Add(item);
    }

    // Remove value
    public void Remove(string item)
    {
        data.Remove(item);
    }

    // Print list
    public void Display()
    {
        Console.WriteLine("{" + string.Join(", ", data) + "}");
    }
}

// Main class
class Program
{
    public static void Main(string[] args)
    {
        // Simple test data
        Store store = new Store();
        store.Add("gfhdfgh");
        store.Add("1");
        store.Add("asdfa");
        store.Add("3");
        store.Add("yuituit");
        //store.Remove("3"); 
        store.Display();
    }
}
