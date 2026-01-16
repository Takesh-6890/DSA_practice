using System;
class Program
{
  static void Main()
  {
    int[] arr={1,1,2,2,3,3,4,4,5,5};
    int slow=0;
    for(int fast=1;fast<arr.Length;fast++)
    {
      if(arr[fast]!=arr[slow])
      {
        slow++;
        arr[slow]=arr[fast];
        
      }
      
    }
    for(int i=0;i<=slow;i++)
      {
        Console.WriteLine(arr[i]);
      }
  }

}