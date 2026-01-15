using System;
class Deletion_s
{
    public  static void Execute()
    {
        int[] arr = { 10, 20, 30, 40 };
        int size = arr.Length;
        int position = 2;
        for(int i=position;i<size-1;i++)
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