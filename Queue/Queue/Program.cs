using System;
using System.Collections;
class Program
{
    public static void Main(string[] args)
    {
        Queue q = new Queue();
        q.Enqueue(1);
        q.Enqueue(2);
        q.Enqueue(3);
        q.Enqueue(4);
        q.Enqueue(5);

        foreach(int i in q)
        {
            Console.Write(i + " ");
        }

        //q.Clear();

        Console.WriteLine();
        Console.WriteLine("Length :- " + q.Count);
        q.Dequeue();
        foreach(int i in q)
        {
            Console.WriteLine(i);
        }

        if (q.Contains(2))
        {
            Console.WriteLine("2 is present");
        }
        else
        {
            Console.WriteLine("2 is not present");
        }
    }
}