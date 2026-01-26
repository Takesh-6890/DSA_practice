
using System;
using System.Collections.Generic;
using System.Text;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string str = "Programming";

        HashSet<char> s=new HashSet<char>();
        StringBuilder result=new StringBuilder();
        foreach(char c in str)
        {
            if(!s.Contains(c))
            {
                s.Add(c);
                result.Append(c);
            }
            
        }
        Console.WriteLine(result.ToString());
        
    }
}