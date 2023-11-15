using System;
using System.Collections;
class Program
{
    public static void Main(string[] args)
    {
        Hashtable ht = new Hashtable();
        ht.Add("Thor", "Chris Hemsworth");
        ht.Add("Spiderman", "Tom Holland");
        ht.Add("Ironman", "Robert Downey JR");
        ht.Add("Captain Marvel", "Brie Larson");
        ht.Add("Scarlet Witch", "Elizabeth Olsen");

        // ht.Remove("Thor");   // Removes the element based on the key.

        IDictionaryEnumerator en = ht.GetEnumerator();
        while (en.MoveNext())
        {
            Console.WriteLine(en.Key + "  -->  " + en.Value);
        }
    }
}