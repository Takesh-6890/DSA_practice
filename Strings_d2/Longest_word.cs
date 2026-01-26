
using System;
using System.Collections.Generic;
using System.Text;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string str = "i am learning Data Structures";
        string[] words=str.Split(' ');
        string longword="";
        foreach(string word in words)
        {
            if(word.Length>longword.Length)
            {
                longword=word;
                
            }
        }
        Console.WriteLine(longword);

        
        
    }
}
