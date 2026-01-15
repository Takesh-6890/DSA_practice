class Insertion
{
   public  static void Run()

    //insertion at starting of the index
    {
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        int[] num = { 10, 20, 30, 40 };
        int newele = 7;
        int[] newnum = new int[num.Length + 1];

        newnum[0] = newele;
        for (int i = 0; i < num.Length; i++)
        {
            newnum[i + 1] = num[i];
        }
        foreach (int i in newnum)
        {
            Console.WriteLine(i);
        }
    }


   
}