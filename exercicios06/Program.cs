// See https://aka.ms/new-console-template for more information
Console.WriteLine("digite um número:");
int ano = Convert.ToInt32(Console.ReadLine());

if(ano % 4 == 0 && !(ano % 100 == 0))
{
    
    Console.WriteLine(ano + " é um ano bissexto");
}
else
{
    if (ano % 400 == 0)
    {
        Console.WriteLine(ano + " é um ano bissexto");
    }
    else
    {
        Console.WriteLine(ano + " não é um ano bissexto");
    }
}
