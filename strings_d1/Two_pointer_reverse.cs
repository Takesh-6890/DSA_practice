string s="takesh";
char[] arr=s.ToCharArray();
int left=0;
int right=arr.Length-1;
while(left<right)
{
  char temp=arr[left];
  arr[left]=arr[right];
  arr[right]=temp;
  
  left++;
  right--;
}
string rev=new string(arr);
Console.WriteLine(rev);