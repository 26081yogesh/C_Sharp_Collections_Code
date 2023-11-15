using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    {
        SortedList<int, string> sortedlist = new SortedList<int, string>();
        sortedlist.Add(1, "Sunday");
        sortedlist.Add(2, "Monday");
        sortedlist.Add(3, "Tuesday");
        sortedlist.Add(4, "Wednesday");
        sortedlist.Add(5, "Thursday");
        sortedlist.Add(6, "Friday");
        sortedlist.Add(7, "Saturday");

        sortedlist.Remove(2);

        foreach(KeyValuePair<int, string> pair in sortedlist)
        {
            Console.WriteLine(pair.Key + "  -->  " + pair.Value);
        }

        Console.WriteLine("Size is :- " + sortedlist.Count);

        // Contains Key
        if (sortedlist.ContainsKey(1))
        {
            Console.WriteLine("Key Is Present");
        }
        else
        {
            Console.WriteLine("Key Is Not Present");
        }

        // Contains Valuie
        if (sortedlist.ContainsValue("Saturday"))
        {
            Console.WriteLine("Value Is Present");
        }
        else
        {
            Console.WriteLine("Value Is Not Present");
        }
     }
}