using System;
class Insertion_S
{
    public static void Exe()
    {
        int[] num = { 10, 20, 40, 50 };
        int newel = 30;
        int position = 2;
        int[] newnum = new int[num.Length + 1];
        for(int i = 0; i < position; i++)
        {
            newnum[i] = num[i];

        }
        newnum[position] = newel;
        for(int i=position;i<num.Length;i++)
        {
            newnum[i + 1] = num[i];
        }
        foreach(int i in newnum)
        {
            Console.WriteLine(i);
        }

    }

    
}