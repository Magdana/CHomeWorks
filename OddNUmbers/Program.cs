Console.Write("Enter the number: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine($"Odd numbers to {num}: ");
for (int i = 1; i <= num; i++)
{
    if (i % 2 == 1)
    {
        Console.Write(i + " ");
    }
    else 
    { 
        continue; 
    }
}

