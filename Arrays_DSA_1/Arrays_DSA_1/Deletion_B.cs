using System;
class Deletion_B
{
    public static void Run()
    {
        int[] arr = { 10, 20, 30, 40 };
        int size = arr.Length;
        for (int i=0;i<size-1;i++)
        {
            arr[i] = arr[i + 1];
        }
        size--;
        for(int i=0;i<size;i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
   
}
