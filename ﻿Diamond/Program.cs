Console.Write("enter the number: ");
int num = int.Parse(Console.ReadLine());

string str = "";

for (int i = 1; i <= num; i++)
{
    for (int j = 1; j <= (num - i); j++)
    {
        str += " ";
    }

    for (int m = 0; m < (2 * i - 1); m++)
    {
        str += "*";
    }

    str += "\n";
}
for (int i = num - 1; i >= 1; i--)
{
    for (int j = 1; j <= (num - i); j++)
    {
        str += " ";
    }

    for (int m = 0; m < (2 * i - 1); m++)
    {
        str += "*";
    }

    str += "\n";
}

Console.WriteLine(str);