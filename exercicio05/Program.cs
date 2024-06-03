// See https://aka.ms/new-console-template for more information
var nota = new double[3];
double acumulador = 0;
for(int i = 0; i < 3; i++)
{
    Console.WriteLine("digite a  " + (i + 1) + "° nota");
    nota[i] = Convert.ToDouble(Console.ReadLine());
    acumulador+= nota[i];
}
Console.WriteLine("a média so aluno é " + (acumulador / 3));