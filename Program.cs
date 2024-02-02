//used libraries
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Store
{
    // Attributes
    List<string> datatext = new List<string>();
    List<string> datanumber = new List<string>();
    List<string> datacompound = new List<string>();

    public Store() { }

    public void insert_filter(string data)
    {
        CheckType ct = new CheckType();
        int type = ct.CheckTypeFunction(data);

        switch (type)
        {
            case 0:
                datanumber.Add(data);
                break;
            
            case 1:
                datatext.Add(data);
                break;
                
            case -1:
                datacompound.Add(data);
                break;
        }
    }

    void remove(string data)
    {
        
    }

    void search(string data)
    {
       
    }

    void get(string data)
    {
       
    }

    public void print()
    {
        Console.WriteLine("\nDataNumber:");
        foreach (var number in datanumber)
        {
            Console.Write("|"+number+"|");
        }

        Console.WriteLine("\n\nDataText:");
        foreach (var text in datatext)
        {
            Console.WriteLine("|"+text+"|");
        }

        Console.WriteLine("\nDataCompound:");
        foreach (var compound in datacompound)
        {
            Console.WriteLine("|"+compound+"|");
        }
    }

    void save(string data)
    {
        
    }
}

class CheckType
{
    public CheckType() { }

    public int CheckTypeFunction(string data)
    {   
        // number
        if (Regex.IsMatch(data, @"^\d+$"))
        {
            return 0;
        }
        // text
        else if (Regex.IsMatch(data, @"^[a-zA-Z]+$"))
        {
            return 1;
        }
        // compound
        else
        {
            return -1;
        }
    }
}

class Analyze
{
    // Attributes
    List<string> datatextcopy = new List<string>();
    List<string> datanumbercopy = new List<string>();
    List<string> datacompoundcopy = new List<string>();
    
    public Analyze(List<string> datatext, List<string> datacompound, List<string> datanumber)
    {
        datatextcopy = datatext;
        datacompoundcopy = datacompound;
        datanumbercopy = datanumber;
    }

    void media()
    {
        
    }

    void standardDeviation()
    {
        
    }

    void frequency()
    {
        
    }
}

class Program
{
    static void Main()
    {
        //test
        Store store = new Store();
        store.insert_filter("1");
        store.insert_filter("2a");
        store.insert_filter("a");
        store.print();
    }
}