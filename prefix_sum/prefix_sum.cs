using System;
class Program
{
  public static void Main()
  {
    int[] arr={10,20,30,40};
    int n=arr.Length;
    int [] prefixarr=new int[n];
    prefixarr[0]=arr[0];
    for(int i=1;i<n;i++)
    {
      prefixarr[i]=prefixarr[i-1]+arr[i];
    }
    foreach(int p in prefixarr)
    {
      Console.WriteLine(p);
    }
    Console.WriteLine();
  }
}