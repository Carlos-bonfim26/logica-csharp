// See https://aka.ms/new-console-template for more information
Console.WriteLine("digite seu peso:");
double peso = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("digite sua altura:");
double altura = Convert.ToDouble(Console.ReadLine());

double imc = peso / Math.Pow(altura, 2);

if(imc < 18.5)
{
    Console.WriteLine(imc + " abaixo do peso");
} else if(imc < 24.9)
{
    Console.WriteLine(imc + " peso normal");
} else if(imc < 29.9)
{
    Console.WriteLine(imc + " sobrepeso");
} else if(imc < 34.9)
{
    Console.WriteLine(imc + " Obesidade 1");
} else if (imc < 39.9)
{
    Console.WriteLine(imc + " obesidade 2");
}
else
{
    Console.WriteLine(imc + " obesidade 3");
}
