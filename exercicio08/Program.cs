// See https://aka.ms/new-console-template for more information
Console.WriteLine("qual foi sua nota?");
double nota = Convert.ToDouble(Console.ReadLine());

if (nota < 3)
{
    Console.WriteLine("nota F");
} else if (nota < 5)
{
    Console.WriteLine("nota D");
} else if (nota < 7)
{
    Console.WriteLine("nota C");
} else if (nota < 9)
{
    Console.WriteLine("nota B");
}
else
{
    Console.WriteLine("nota A");
}
