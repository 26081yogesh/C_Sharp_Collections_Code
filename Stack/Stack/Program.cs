using System;
using System.Collections;
using System.Collections.Generic;
class Program
{
    public static void Main(string[] args)
    {
        Stack<int> st = new Stack<int>();
        st.Push(1);
        st.Push(3);
        st.Push(5);
        st.Push(4);
        st.Push(2);

        foreach(int i in st)
        {
            Console.Write(i + " ");
        }

        Console.WriteLine();
        st.Pop();
        foreach(int i in st)
        {
            Console.Write(i + " ");
        }

    }
}