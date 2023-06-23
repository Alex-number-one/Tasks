int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    Console.WriteLine ("max = " + a );
    Console.WriteLine ("min = " + b);
}
else if (a == b)
{
    Console.WriteLine ("they are equal");
}
else 
{
    Console.WriteLine ("max = " + b);
    Console.WriteLine ("min = " + a);
}
