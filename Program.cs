Console.Write("Введите число: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int n3 = Convert.ToInt32(Console.ReadLine());
int max = n1;

if (n2 > max)
{
    max = n2;
}
if (n3 > max)
{
    max = n3;
}

Console.Write ("max=");
Console.WriteLine (max);
