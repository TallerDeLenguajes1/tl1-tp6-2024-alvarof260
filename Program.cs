// See https://aka.ms/new-console-template for more information
/* Console.WriteLine("Hello, World!");

int a;

int b;

a=10;

b=a;

Console.WriteLine("El valor de a: " + a);

Console.WriteLine("El valor de b: " + b); */


/* Console.WriteLine("Ingrese un numero:");
int number = Convert.ToInt32(Console.ReadLine());
int inv = 0;

while (number != 0)
{
    int digit = number % 10;
    inv = inv * 10 + digit;
    number = number / 10;
}

Console.Write(inv); */

int opcion;
double num;

do
{
    Console.WriteLine("Calculadora V2\n");
    Console.WriteLine("1 - Valor absoluto\n");
    Console.WriteLine("2 - Cuadrado\n");
    Console.WriteLine("3 - Raiz Cuadrada\n");
    Console.WriteLine("4 - Seno\n");
    Console.WriteLine("5 - Coseno\n");
    Console.WriteLine("6 - La parte entera de un tipo float\n");
    Console.WriteLine("0 - Salir\n");
    opcion = Convert.ToInt32(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            Console.WriteLine("Ingrese el numero\n");
            num = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("El valor absoluto: " + Math.Abs(num));
            break;
        case 2:
            Console.WriteLine("Ingrese el numero\n");
            num = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"El cuadrado de {num}: {Math.Pow(num, 2)}");
            break;
        case 3:
            Console.WriteLine("Ingrese el numero\n");
            num = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"El cuadrado de {num}: {Math.Sqrt(num)}");
            break;
        case 4:
            Console.WriteLine("Ingrese el numero\n");
            num = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"El seno de {num}: {Math.Sin(num)}");
            break;
        case 5:
            Console.WriteLine("Ingrese el numero\n");
            num = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"El coseno de {num}: {Math.Cos(num)}");
            break;
        case 6:
            Console.WriteLine("Ingrese el numero\n");
            num = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"El coseno de {num}: {Math.Truncate(num)}");
            break;
        case 0:
            Console.WriteLine("Saliendo del programa...\n");
            break;
        default:
            Console.WriteLine("Opcion no valida\n");
            break;
    }

} while (opcion != 0);