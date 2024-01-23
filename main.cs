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
        Sort(); 
    }

    // Remove value
    public void Remove(string item)
    {
        data.Remove(item);
    }
    
    // Search data
    public void Search(string item)
    {
        if(data.Contains(item))
        {
            Console.WriteLine("Dado encontrado!");
        }
        else
        {
            Console.WriteLine("Dado não encontrado!");
        }
    }
    
    // Clear data
    public void Clear()
    {
        data.Clear();
    }
    
    // Get size
    public int GetSize()
    {
        return data.Count;
    }
    
    // Sort data
    public void Sort()
    {
        data.Sort();
    }
    
    // Get item with id
    public string GetItemId(int index)
    {
        if (index >= 0 && index < data.Count)
        {
            return data[index];
        }
        else
        {
            return "Index out of range";
        }
    }

    // Print list
    public void Display()
    {
        Console.WriteLine("{" + string.Join(", ", data) + "}");
    }
    
    // See if it's empty
    public bool IsEmpty()
    {
        return data.Count == 0;
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
        store.Search("3");
        //store.Remove("3"); 
        //store.Display();
    }
}
