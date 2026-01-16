using System;
class Program
{
  static void Main()
  {
    int[] arr={1,5,3,4,6,2,4};
    int target=10;
    int left=0;
    int sum=0;
    int minLength=int.MaxValue;
    for (int r=0;r<arr.Length;r++)
    {
      sum+=arr[r];
      while(sum>=target)
      {
        minLength=Math.Min(minLength,r-left+1);
        sum-=arr[left];
        left++;
      }
    }
    Console.WriteLine(minLength==int.MaxValue ? 0: minLength);
  }
}