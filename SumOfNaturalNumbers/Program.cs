Console.Write("enter the number: ");
int num=int.Parse(Console.ReadLine());
int sum = 0;
Console.WriteLine($"The first {num} natural number is: ");
for (int i=1; i<=num; i++)
{
    Console.Write($"{ i} ");
    sum += i;
}
Console.WriteLine($"\nThe sum of Natural Number upto {num} terms: {sum}");
