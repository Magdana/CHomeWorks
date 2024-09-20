Console.Write("enter the number: ");
int num = int.Parse(Console.ReadLine());
char[] charArr = num.ToString().ToCharArray();
int sum = 0;
foreach (char c in charArr)
{
    int charInt = c - '0';
    sum += charInt;
}
Console.WriteLine("sum of the digits is: " + sum);