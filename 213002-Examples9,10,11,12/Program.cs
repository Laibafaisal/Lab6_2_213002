using System;
class Program
{
    static void Main(string[] args)
    {
        //Example 9
        IList<int> l1 = new List<int>() { 10, 20, 30, 40, 50 };
        l1.Insert(1, 11);
        foreach(int i in l1)
        {
            Console.WriteLine(i);
        }

        //Example 10
        l1.Remove(30);
        foreach (int i in l1)
        {
            Console.WriteLine(i);
        }
        l1.RemoveAt(0);
        foreach (int i in l1)
        {
            Console.WriteLine(i);
        }

        //Example 11
        List<int> l = new List<int>() { 125, 225, 325, 425, 525 };
        bool result = l.TrueForAll(el => el % 5 == 0);
        Console.WriteLine(result);
        bool result2 = l.TrueForAll(el => el % 2 == 0);
        Console.WriteLine(result2);

        //Example 12
        List<int> intList = new List<int>() { 10, 20, 30, 40 };
        bool res = intList.TrueForAll(isPositiveInt);
        Console.WriteLine(res);
    }

    static bool isPositiveInt(int i)
    {
        return i > 0;
    }
}