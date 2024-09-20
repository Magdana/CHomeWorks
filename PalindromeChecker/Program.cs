Console.Write("input: ");
string str = Console.ReadLine();
char[] arr = str.ToCharArray();
char[] newArr = arr.Reverse().ToArray();
bool result = arr.SequenceEqual(newArr);
if (result)
{
    Console.WriteLine("true");
}
else
{
    Console.WriteLine("false");
}