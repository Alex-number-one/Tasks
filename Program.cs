//double num = Convert.ToDouble(Console.ReadLine);
/*int first = Convert.ToInt32(Console.ReadLine());
int second = Convert.ToInt32(Console.ReadLine());
if (first == second * second) //before {} never goes ;
{
Console.WriteLine("Yes");
}
else
{
Console.WriteLine("No");
}*/
Console.Write("write number: ");

int N = Convert.ToInt32(Console.ReadLine());
if (N < 0)
{
    N = N * -1;
}
int negativeN = N * -1;
while (negativeN <= N)
{
    Console.WriteLine(negativeN);
negativeN++;
}
