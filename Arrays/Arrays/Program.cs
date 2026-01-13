using System;


// normal array

//1D array
int[] num = { 1, 2, 3 };
//Console.WriteLine(num[0]);
for (int i=0;i<=2;i++)
{
    Console.WriteLine(num[i]);
}

foreach (int n in num)
{
    Console.WriteLine(n);
}


/*long [] m = new long[5];
for (int i=0; i<=m.Length;i++)
{
    Console.WriteLine("enter the elements to store in arry");
    m[i] = Convert.ToInt64(Console.ReadLine());
    Console.WriteLine(m[i]);
}
*/

//2D array


int[,] matrix =
{
    {1,2,3 },
    {4,5,6 },
    {7,8,9 }
};

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}
