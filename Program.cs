int a = Convert.ToInt16(Console.ReadLine());
int b = Convert.ToInt16(Console.ReadLine());
int c = Convert.ToInt16(Console.ReadLine());
int max = a;
if (b > max)
{
    max = b;
}
else
{
    max = a;
}
if (c > max)
{
    max = c;
    Console.WriteLine("max = " + max);
}
else
{
Console.WriteLine("max = " + max);
}