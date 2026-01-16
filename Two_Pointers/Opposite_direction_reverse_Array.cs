using System;
class Program
{
  static void Main()
  {
    int[] arr={1,2,3,4,5,6};
    int left=0;
    int right=arr.Length-1;
    while(left<right)
    {
      int temp=arr[left];
      arr[left]=arr[right];
      arr[right]=temp;
      
      left++;
      right--;
    }
    Console.WriteLine(String.Join(" ",arr));
  }
}