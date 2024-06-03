// See https://aka.ms/new-console-template for more information
Console.WriteLine("digite um número inteiro");
int numero = Convert.ToInt32(Console.ReadLine());
if(numero < 0)
{

    Console.WriteLine(numero +" ao quadrado é " + Math.Pow(numero, 2));
}
else
{
    Console.WriteLine(numero + " a raiz quadrada de é " + Math.Sqrt(numero));
}