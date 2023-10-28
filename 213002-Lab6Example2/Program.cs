using System;
class Program
{
    static void Main()
    {
        IList<int> list1 = new List<int>();
        list1.Add(10);
        list1.Add(20);
        list1.Add(30);
        list1.Add(40);
        list1.Add(50);

        List<int> list2 = new List<int>();
        list2.AddRange(list1);

        foreach (var i in list2)
        {
            Console.WriteLine(i);
        }

    }
}