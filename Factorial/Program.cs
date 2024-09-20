
Console.Write("input: ");
int num = int.Parse(Console.ReadLine());
int fact = 1;
for (int i = 1; i <= num; i++)
{
    fact *= i;
}
Console.WriteLine("output: " + fact);