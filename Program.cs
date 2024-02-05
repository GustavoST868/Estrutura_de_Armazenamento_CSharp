// Used libraries
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

    public void remove(string data)
    {
        CheckType ct = new CheckType();
        int type = ct.CheckTypeFunction(data);

        switch (type)
        {
            case 0:
                datanumber.Remove(data);
                break;

            case 1:
                datatext.Remove(data);
                break;

            case -1:
                datacompound.Remove(data);
                break;
        }
    }

    public void search(string data)
{
    CheckType ct = new CheckType();
    int type = ct.CheckTypeFunction(data);

    switch (type)
    {
        case 0:
            if (datanumber.Contains(data) == true)
            {
                Console.WriteLine("\nDado encontrado!\n");
            }
            break;

        case 1:
            if (datatext.Contains(data) == true)
            {
                Console.WriteLine("\nDado encontrado!\n");
            }
            break;

        case -1:
            if (datacompound.Contains(data) == true)
            {
                Console.WriteLine("\nDado encontrado!\n");
            }
            break;
    }
}


    void get(string data)
    {
        
    }

    public void print()
    {
        Console.WriteLine("\nDataNumber:");
        foreach (var number in datanumber)
        {
            Console.Write("|" + number + "|");
        }

        Console.WriteLine("\n\nDataText:");
        foreach (var text in datatext)
        {
            Console.WriteLine("|" + text + "|");
        }

        Console.WriteLine("\nDataCompound:");
        foreach (var compound in datacompound)
        {
            Console.WriteLine("|" + compound + "|");
        }
    }

    void save(string data)
    {
        
    }
    
    public List<string> Getdatatext(){
        return datatext;
    }
    
    public List<string> Getdatanumber(){
        return datanumber;
    }
    
    public List<string> Getdatacompound(){
        return datacompound;
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
    List<double> datanumber = new List<double>();
    List<string> datacompoundcopy = new List<string>();

    public Analyze(List<string> datatext, List<string> datacompound, List<string> datanumber)
    {
        datatextcopy = datatext;
        datacompoundcopy = datacompound;
        datanumbercopy = datanumber;
    }

    public double media() 
    {
        foreach (string value in datanumbercopy)
        {
            datanumber.Add(double.Parse(value));
        }

        double sum = 0;

        // empty list
        if (datanumber.Count == 0)
        {
            return 0;
        }

        foreach (double value in datanumber)
        {
            sum += value;
        }

        // media
        double media = sum / datanumber.Count;
        return media;
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
        //testing the Store Class 
        Store store = new Store();
        store.insert_filter("1");
        store.insert_filter("4");
        store.insert_filter("20");
        store.insert_filter("2a");
        store.insert_filter("a");
        store.print();
        store.search("a");
        
        //testing the Analyze Class 
        Analyze analyze  = new Analyze(store.Getdatatext(),store.Getdatacompound(),store.Getdatanumber());
        Console.WriteLine("Media = |"+analyze.media()+"|");
    }
}
