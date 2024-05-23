﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/* int a;

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
            Console.WriteLine($"La suma {numA} y de {numB} es igual a: {numA + numB}\n");
            break;
        case 2:
            Console.WriteLine("Ingrese el numero 1: ");
            numA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el numero 2: ");
            numB = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"La resta {numA} y de {numB} es igual a: {numA - numB}\n");
            break;
        case 3:
            Console.WriteLine("Ingrese el numero 1: ");
            numA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el numero 2: ");
            numB = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"La multiplicacion {numA} y de {numB} es igual a: {numA * numB}\n");
            break;
        case 4:
            Console.WriteLine("Ingrese el numero 1: ");
            numA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el numero 2: ");
            numB = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"La division {numA} y de {numB} es igual a: {numA / numB}\n");
            break;
        case 0:
            Console.WriteLine("Saliendo del programa...\n");
            break;
        default:
            Console.WriteLine("Opcion invalida!\n");
            break;
    }
} while (opcion != 0); */

Console.WriteLine("Ingresa una cadena: ");
string text = Console.ReadLine();
int lon = text.Count();
Console.WriteLine($"La cadena {text} tiene {lon} letras");
Console.WriteLine("Ingresa una cadena: ");
string text2 = Console.ReadLine();
string concatText = String.Concat(text, " ", text2);
Console.WriteLine($"concat: {concatText}");
Console.Write("Ingrese el índice de inicio para la subcadena: ");
int indiceInicio = Convert.ToInt32(Console.ReadLine());
Console.Write("Ingrese la longitud de la subcadena: ");
int longitudSubcadena = Convert.ToInt32(Console.ReadLine());
string subcadena = text.Substring(indiceInicio, longitudSubcadena);
Console.WriteLine($"La subcadena extraída es: {subcadena}");

Console.WriteLine("Elementos de cadena");
foreach (char c in text)
{
    Console.WriteLine(c);
}

Console.WriteLine("Ingrese una palabra:");
string palabra = Console.ReadLine();
if (text.Contains(palabra))
{
    Console.WriteLine($"La palabra {palabra}, si se encuentra en la cadena.\n");
}
else
{

    Console.WriteLine($"La palabra {palabra}, no se encuentra en la cadena.\n");
}

string cadenaMayusculas = text.ToUpper();
Console.WriteLine($"Cadena en mayúsculas: {cadenaMayusculas}");

string cadenaMinusculas = text.ToLower();
Console.WriteLine($"Cadena en minúsculas: {cadenaMinusculas}");

Console.Write("Ingrese una cadena separada por comas: ");
string cadenaSeparada = Console.ReadLine();
string[] partes = cadenaSeparada.Split(',');
Console.WriteLine("Partes de la cadena separada:");
foreach (string parte in partes)
{
    Console.WriteLine(parte.Trim());
}
