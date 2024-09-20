Console.WriteLine("Sum of Prime Numbers within a Range ");
Console.Write("Enter the starting value of the range: ");
int start = int.Parse(Console.ReadLine());
Console.Write("Enter the ending value of the range: ");
int end = int.Parse(Console.ReadLine());
int sum = 0;

for (int i = start; i <= end; i++)
{
    if (IsPrime(i))
    {
        sum += i;
    }
}
Console.WriteLine("sum of prime numbers within range: " + sum);
static bool IsPrime(int number)
{
    if (number <= 1) return false;
    for (int j = 2; j <= Math.Sqrt(number); j++)
    {
        if (number % j == 0)
        {
            return false;
        }
    }
    return true;
}