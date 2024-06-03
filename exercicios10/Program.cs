// See https://aka.ms/new-console-template for more information
Console.WriteLine("calculadora");
Console.WriteLine("digite um número");
double numero1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("digite outro número");
double numero2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("digite um operador + - * /");
char operador = Convert.ToChar(Console.ReadLine());

switch (operador)
{
    case '+':
        Console.WriteLine(numero1 + " + " + numero2 + " = " + (numero1 + numero2));
        break;
    case '-':
        Console.WriteLine(numero1 + " - " + numero2 + " = " + (numero1 - numero2));
        break;
    case '*':
        Console.WriteLine(numero1 + " * " + numero2 + " = " + (numero1 * numero2));
        break;
    case '/':
        Console.WriteLine(numero1 + " / " + numero2 + " = " + (numero1 / numero2));
        break;
    default:
        Console.WriteLine("operador inválido");
        break;
}