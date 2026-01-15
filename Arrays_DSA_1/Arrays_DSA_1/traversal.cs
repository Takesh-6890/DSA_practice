using System;
class Traversal
{
    public static void run()
    {

    //traversal
        int[] num = { 10, 20, 30, 40 };
        Console.WriteLine(num[2]);

        for (int i =0;i<num.Length;i++)
        {
            Console.WriteLine(num[i]);
        }
        foreach(int i in num)
        {
            Console.WriteLine(i);
        }

    }

}

