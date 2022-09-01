Console.Write("input number A: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("input number B: ");
int numberB = int.Parse(Console.ReadLine());

if(Math.Pow(numberA,2)==numberB)
{
    Console.WriteLine("A является квадратом B");
}
else
{
    Console.WriteLine("A не является квадратом B");
}
