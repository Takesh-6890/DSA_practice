using System;
using System.Text;
string s = "abcd";
StringBuilder sb= new StringBuilder(s);
for(int 1=0,j=sb.Length-1;i<j;i++,j--)
{
  char temp=sb[i];
  sb[i]=sb[j];
  sb[j]=temp;

}
string rev=sb.ToString();
Console.WriteLine(rev);
