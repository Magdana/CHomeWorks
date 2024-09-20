Console.Write("Input: ");
int num = int.Parse(Console.ReadLine());
int sum = 0;
Console.Write("Output: ");
for (int i = 1; i <= num; i++)
{
    string member = "";
    for (int j = 0; j < i; j++)
    {
        member += "9";
    }
    sum += int.Parse(member);
    Console.Write(member + " ");

}
Console.WriteLine("\nThe sum of the series: " + sum);
