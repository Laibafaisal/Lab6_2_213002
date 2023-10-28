using System;
class Program
{
    static void Main(string[] args)
    {
        //Example 3
        List<int> l1 = new List<int>() { 10, 20, 30, 40 };
        l1.ForEach(el => Console.WriteLine(el));

        //Example 4
        IList<int> l2 = new List<int>() { 100, 200, 300, 400 };
        foreach (var el in l2)
        {
            Console.WriteLine(el);
        }
    }
}


   