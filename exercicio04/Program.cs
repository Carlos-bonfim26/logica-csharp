// See https://aka.ms/new-console-template for more information
Console.WriteLine("verificando triângulo");
Console.WriteLine("digite o 1° lado do triângulo");
double lado1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("digite o 2° lado do triângulo");
double lado2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("digite o 3° lado do triângulo");
double lado3 = Convert.ToDouble(Console.ReadLine());

if(lado1 + lado2 < lado3 || lado1 + lado3 < lado2 || lado2 + lado3 < lado1)
{
    Console.WriteLine("não é um triângulo");
}
else
{
    Console.WriteLine("é um triângulo");
}