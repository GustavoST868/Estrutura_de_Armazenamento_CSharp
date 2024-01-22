using System;


//store data in general
class Store
{
    //attributes
    private string[] data = new string[1000];
    private int position = 0;
    
    //constructor
    public Store() { }

    //add value
    public void Add(string item)
    {
        data[position] = item;
        position++;
    }
    
    //remove value with void
    public void Remove(int id){
        data[id]=null;
    }
    
    //print value
    public void Display()
    {
        //local attributes
        string[] dataStruct = new string[position + 2];
        int positionDataStruct = 0;

        
        dataStruct[positionDataStruct] = "{";
        
        //add data to vector
        for (int i = 0; i < position; i++)
        {
            dataStruct[positionDataStruct + 1] = $"  {data[i]}  ,";
            positionDataStruct++;
        }

        dataStruct[positionDataStruct + 1] = "}";

        //print vector
        Console.WriteLine(string.Join(" ", dataStruct));
    }
}



//main class
class Program
{
    public static void Main(string[] args)
    {
        // simple test data
        Store store = new Store();
        store.Add("gfhdfgh");
        store.Add("1");
        store.Add("asdfa");
        store.Add("3");
        store.Add("yuituit");
        //store.Remove(5);
        store.Display();
    }
}
