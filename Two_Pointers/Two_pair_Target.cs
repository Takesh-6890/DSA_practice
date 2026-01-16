using System;
class Program
{
  static void Main()
  {
    int[] arr={1,3,4,5,7,};
    int left=0;
    int right=arr.Length-1;
    int target=9;
    while(left<right)
    {
      int sum=arr[left]+arr[right];
      if(sum==target)
      {
        Console.WriteLine($"Pair found {arr[left]},{arr[right]}");
        break;
      }
      else if(sum<target)
      {
        left++;
      }
      else
      {
        right--;
      }
    }
  }
}