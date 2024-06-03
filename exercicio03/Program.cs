// See https://aka.ms/new-console-template for more information

Console.WriteLine("escreva um número inteiro");
int numero1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("escreva outro número inteiro");
int numero2 = Convert.ToInt32(Console.ReadLine());

if(numero1 > numero2){
    Console.WriteLine(numero1 + " é maior que " + numero2);
} else if(numero1 == numero2){
    Console.WriteLine("são iguais");
}
else
{
    Console.WriteLine(numero2 +" é maior que " + numero1);
}