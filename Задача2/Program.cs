Console.WriteLine("Hello, World!");

Console.Write("Введите номер дня недели: ");
int A = Convert.ToInt32(Console.ReadLine());

if (A==1)
{
    Console.WriteLine("Monday");
}
else if (A==2)
{
    Console.WriteLine("Tuesday");
}
else if (A==3)
{
    Console.WriteLine("Wednesday");
}
else if (A==4)
{
    Console.WriteLine("Thursday");
}
else if (A==5)
{
    Console.WriteLine("Friday");
}
else if (A==6)
{
    Console.WriteLine("Saturday");
}
else if (A==7)
{
    Console.WriteLine("Sunday");
}
else 
{
    Console.WriteLine("Неверное число");
}
