while(true)
{
Console.WriteLine();
Console.WriteLine("====CALCULADORA====");
Console.WriteLine("1. Sumar");
Console.WriteLine("2. Restar");
Console.WriteLine("3. Multiplicar");
Console.WriteLine("4. Dividir");
Console.WriteLine("5. Salir");
Console.WriteLine();

int opción = int.Parse(Console.ReadLine());

if(opción == 1)
    {
        Console.WriteLine("Introduce el primer número: ");
        int n1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Introduce el segundo número: ");
        int n2 = int.Parse(Console.ReadLine());

        Console.WriteLine("El resultado es: ");
        Console.WriteLine(n1 + n2);
    }
else if(opción == 2)
    {
        Console.WriteLine("Introduce el primer número: ");
        int n1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Introduce el segundo número: ");
        int n2 = int.Parse(Console.ReadLine());

        Console.WriteLine("El resultado es: ");
        Console.WriteLine(n1 - n2);
    }
else if(opción == 3)
    {
        Console.WriteLine("Introduce el primer número: ");
        int n1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Introduce el segundo número: ");
        int n2 = int.Parse(Console.ReadLine());

        Console.WriteLine("El resultado es: ");
        Console.WriteLine(n1 * n2);
    }
else if(opción == 4)
    {
        Console.WriteLine("Introduce el primer número: ");
        int n1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Introduce el segundo número: ");
        int n2 = int.Parse(Console.ReadLine());

        Console.WriteLine("El resultado es: ");
        Console.WriteLine(n1 / n2);
    }
else if(opción == 5)
    {
        Console.WriteLine("¡Hasta luego Mari Carmen!");
        break;
    }
else
    {
        Console.WriteLine("Opción no válida.");
    }
}