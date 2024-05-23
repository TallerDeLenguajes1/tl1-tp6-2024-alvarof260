// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int a;

int b;

a = 10;

b = a;

Console.WriteLine("El valor de a: " + a);

Console.WriteLine("El valor de b: " + b);


Console.WriteLine("Ingrese un numero:");
int number = Convert.ToInt32(Console.ReadLine());
int inv = 0;

while (number != 0)
{
    int digit = number % 10;
    inv = inv * 10 + digit;
    number = number / 10;
}

Console.Write(inv);

int opcion;
double numA = 0;
double numB = 0;

do
{
    Console.WriteLine("Calculadora\n");
    Console.WriteLine("1- Sumar\n");
    Console.WriteLine("2- Restar\n");
    Console.WriteLine("3- Multiplicar\n");
    Console.WriteLine("4- Dividir\n");
    Console.WriteLine("0- Salir\n");
    opcion = Convert.ToInt32(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            Console.WriteLine("Ingrese el numero 1: ");
            numA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el numero 2: ");
            numB = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"El resultado es: {numA + numB}\n");
            break;
        case 2:
            Console.WriteLine("Ingrese el numero 1: ");
            numA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el numero 2: ");
            numB = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"El resultado es: {numA - numB}\n");
            break;
        case 3:
            Console.WriteLine("Ingrese el numero 1: ");
            numA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el numero 2: ");
            numB = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"El resultado es: {numA * numB}\n");
            break;
        case 4:
            Console.WriteLine("Ingrese el numero 1: ");
            numA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el numero 2: ");
            numB = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"El resultado es: {numA / numB}\n");
            break;
        case 0:
            Console.WriteLine("Saliendo del programa...\n");
            break;
        default:
            Console.WriteLine("Opcion invalida!\n");
            break;
    }
} while (opcion != 0);