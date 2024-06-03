// See https://aka.ms/new-console-template for more information
Console.WriteLine("digite um número inteiro:");
int numero = Convert.ToInt32(Console.ReadLine());

if (numero > 100)
{
    Console.WriteLine("é maior que 100");
}
else
{
    Console.WriteLine("dobrei: " + numero * 2);
}
