using System;
class Insretion_E
{
   public  static void Execute()
    {
        int[] num = { 10, 20, 30, 40 };
        int newele = 50;
        int[] newnum = new int[num.Length + 1];
        for(int i=0;i<num.Length;i++)
        {
            newnum[i] = num[i];
        }
        newnum[num.Length] = newele;
        foreach(int i in newnum)
        {
            Console.WriteLine(i);
        }

    }
  
}