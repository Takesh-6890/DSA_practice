using System;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string str = "Programming";

        Dictionary<char, int> count = new Dictionary<char, int>();

        foreach (char c in str)
        {
            if (count.ContainsKey(c))
            {
                count[c]++;
            }
            else
            {
                count[c] = 1;
            }
        }

        foreach (var item in count)
        {
            Console.WriteLine($"{item.Key} --> {item.Value}");
        }
    }
}
