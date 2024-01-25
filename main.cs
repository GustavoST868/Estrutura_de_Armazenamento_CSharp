// Used libraries
using System;
using System.Collections.Generic;
using System.Linq;

// Store data in general
class Store
{
    // Attributes
    public List<string> data_text = new List<string>();
    public List<int> data_number = new List<int>();
    public List<string> data_compound = new List<string>();

    // Constructor
    public Store() { }

    // Add value
    public void Add(string item)
    {
        data_text.Add(item);
        Sort();
    }

    // Remove value
    public void Remove(string item)
    {
        data_text.Remove(item);
    }

    // Search data
    public void Search(string item)
    {
        if (data_text.Contains(item))
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
        data_text.Clear();
    }

    // Get size
    public int GetSize()
    {
        return data_text.Count;
    }

    // Sort data
    public void Sort()
    {
        data_text.Sort();
    }

    // Get item with id
    public string GetItemId(int index)
    {
        if (index >= 0 && index < data_text.Count)
        {
            return data_text[index];
        }
        else
        {
            return "Index out of range";
        }
    }

    // Print list
    public void Display()
    {
        Console.WriteLine("data_text__{ " + string.Join(" , ", data_text) + " }");
    }

    // See if it's empty
    public bool IsEmpty()
    {
        return data_text.Count == 0;
    }

    // Function to check the data type
    public int CheckType(string str)
    {
        bool isText = str.All(char.IsLetter);
        bool isNumber = double.TryParse(str, out _);

        if (isText)
        {
            // If it is text
            Console.WriteLine("É texto");
            return 0;
        }
        else if (isNumber)
        {
            // If it is number
            Console.WriteLine("É número");
            return 1;
        }
        else
        {
            // If it is neither text nor number
            Console.WriteLine("Não é nem texto nem número");
            return -1;
        }
    }

    // Convert to int
    public int ConvertToInt(string str)
    {
        if (int.TryParse(str, out int result))
        {
            return result;
        }
        else
        {
            Console.WriteLine("Erro ao converter para int. Retornando 0.");
            return 0;
        }
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
        store.CheckType("222");
        //store.Search("3");
        //store.Remove("3"); 
        //store.ConvertToInt("1");

        store.Display();
    }
}
