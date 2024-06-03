// See https://aka.ms/new-console-template for more information
Console.WriteLine("digite um número inteiro:");
int numero1 = Convert.ToInt32(Console.ReadLine());

if(numero1 >9 && numero1 < 21)
{
    Console.WriteLine("está no intervalo entre 10 e 20");
}
else
{
    Console.WriteLine("não está no intervalo entre 10 e 20");
}
