// See https://aka.ms/new-console-template for more information
Console.WriteLine("digite um número inteiro:");
int i = Convert.ToInt32(Console.ReadLine());


if (i > 0)
{
    Console.WriteLine(i + " é positivo");
}
else if (i < 0)
{
    Console.WriteLine(i + " é negativo");
}
else
{
    Console.WriteLine("é zero");
}


