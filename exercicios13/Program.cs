// See https://aka.ms/new-console-template for more information
Console.WriteLine("valor do ingresso:");
double valor = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("qual a sua categoria 1 - comum,2 - associado, 3 - vip ");
int categoria = Convert.ToInt32(Console.ReadLine());

switch (categoria) {
    case 1:
        Console.WriteLine("sem desconto r$" + valor);
        break;
    case 2:
        Console.WriteLine("10% de desconto r$" + (valor - (valor / 10)));
        break;
    case 3:
        Console.WriteLine("20% de desconto r$" + (valor - (valor / 5)));
        break;
    default:
        Console.WriteLine("tipo de usuário inválido");
        break;
}
