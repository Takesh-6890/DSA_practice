using System;
class Program
{
  static void Main()
  {
     int[] arr={1,5,3,7,8,9};
     int k=3;
     int maxsum=0;
     int windowsum=0;
     for(int i=0;i<k;i++)
     {
       windowsum+=arr[i];
     }
     maxsum=windowsum;
     for(int i=k;i<arr.Length;i++)
     {
       windowsum+=arr[i];
       windowsum-=arr[i-k];
       maxsum=Math.Max(maxsum,windowsum);
     }
    Console.WriteLine(maxsum);
  }

}