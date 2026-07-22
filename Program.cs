using System.Runtime.InteropServices.Marshalling;

Console.WriteLine("Bienvenido a la calculadora :D");

Console.WriteLine("Introduce el primer número.");
string numero1 = Console.ReadLine();

Console.WriteLine("Introduce el segundo número.");
string numero2 = Console.ReadLine();

int n1 = int.Parse(numero1);
int n2 = int.Parse(numero2);

Console.WriteLine("¿Qué operación quieres hacer?");
Console.WriteLine("+ para sumar");
Console.WriteLine("- para restar");
Console.WriteLine("* para multiplicar");
Console.WriteLine("/ para dividir");

string operación = Console.ReadLine();

if(operación == "+")
{
    Console.WriteLine("El resultado es:");
    Console.WriteLine(n1 + n2);
}
else if (operación == "-")
{
    Console.WriteLine("El resultado es:");
    Console.WriteLine(n1 - n2);
}
else if (operación == "*")
{
    Console.WriteLine("El resultado es:");
    Console.WriteLine(n1 * n2);
}
else if (operación == "/")
{
    Console.WriteLine("El resultado es:");
    Console.WriteLine(n1 / n2);
}
else
{
    Console.WriteLine("Operación no válida.");
    return;
}