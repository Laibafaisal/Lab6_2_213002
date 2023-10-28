using System;
class program
{
    static void Main(string[] args)
    {
        //Example 5
        Console.WriteLine("Example 5");
        IList<int> list1 = new List<int>() { 100, 200, 300, 400, 500 };
        int element = list1[1];
        Console.WriteLine($"The second element in list1 is: {element}.");

        //Example 6
        Console.WriteLine("Example 6");
        Console.WriteLine("The total number of elements in list1 is: {0}", list1.Count);

        //Example 7
        Console.WriteLine("Example 7");
        for (int i = 0; i < list1.Count; i++)
        {
            Console.WriteLine(list1[i]);
        }

        //Example 8
        Console.WriteLine("Example 8");
        //creating a string array
        string[] strarray = new string[2];
        strarray[0] = "Hello";
        strarray[1] = "World!";
        Print(strarray);

        //creating a new list
        IList<string> strlist = new List<string>();
        strlist.Add("Hello");
        strlist.Add("World!!!");
        Print(strlist);
    }

   static void Print(IList <string> list)
    {
        foreach (string value in  list)
        {
            Console.WriteLine(value);
        }
    }
    
}