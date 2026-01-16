using System;
class Program
{
  static void Main()
  {
    string s="madam";
    int left=0;
    int right=s.Length-1;
    bool isPlaindrome=true;
    while(left<right)
    {
      if(s[left]!=s[right])
      {
        isPlaindrome=false;
        break;
      }
      left++;
      right--;
    }
    Console.WriteLine(isPlaindrome);
  }
}