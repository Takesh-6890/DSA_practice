using System;
class Deletion_E
{
    public static void Run()
    {
        int[] ayy = { 10, 20, 30, 40, 50 };
        int size = ayy.Length;
        size--;
        for(int i=0;i<size;i++)
        {
            Console.WriteLine(ayy[i]);
        }
    }
    
}
