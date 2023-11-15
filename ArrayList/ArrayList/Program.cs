using System;
using System.Collections;
class Program
{
    public static void Main(String[] args)
    {
        ArrayList al = new ArrayList();
        al.Add(1);
        al.Add(1000);
        al.Add(2);
        al.Add(3);
        al.Add(4);
        al.Add(5);

        //al.Clear();
        //al.Remove(1);
        //al.RemoveAt(0);
        //al.RemoveRange(0, 2);

        //al.Sort();

        foreach(int i in al){
            Console.Write(i + " ");
        }

        //Console.WriteLine(al.Count);

        //al.Insert(1, 99);
        Console.WriteLine();
        /*foreach(int i in al)
        {
            Console.Write(i + " ");
        } */ 


    }
}