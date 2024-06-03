// See https://aka.ms/new-console-template for more information
Console.WriteLine("escreva o código do produto:");
int codigo = Convert.ToInt32(Console.ReadLine());


 if (codigo < 11 && codigo > 0) 
{
    Console.WriteLine("Alimento não pericível");
} else if (codigo < 21 && codigo > 10)
{
    Console.WriteLine("Alimento pericível");
} else if (codigo < 31 && codigo > 20)
{
    Console.WriteLine("Vestuário");
} else if( codigo < 41 && codigo > 30)
{
    Console.WriteLine("Eletrônicos");
}
else
{
    Console.WriteLine("Código inválido");
}