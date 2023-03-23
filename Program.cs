Console.Write("Введите число: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int n2 = Convert.ToInt32(Console.ReadLine());
int max = n1;
int min = n1;

if (n2 > max)
{
    max = n2;
}
if (n2 < min)
{
    min = n2;
}

Console.Write ("max=");
Console.WriteLine (max);
Console.Write ("min=");
Console.WriteLine (min);