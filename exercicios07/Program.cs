// See https://aka.ms/new-console-template for more information
Console.WriteLine("qual a sua idade");
int idade = Convert.ToInt32(Console.ReadLine());

if(idade < 0)
{
    Console.WriteLine("idade inválida");
}
else if(idade < 13)
{
    Console.WriteLine("você é uma Criança");
} else if(idade < 18)
{
    Console.WriteLine("você é um Adolescente");
} else if (idade < 60)
{
    Console.WriteLine("você é um Adulto");
}
else
{
    Console.WriteLine("você é um Idoso");
}
