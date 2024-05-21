// See https://aka.ms/new-console-template for more information
/* Console.WriteLine("Hello, World!");

int a;

int b;

a=10;

b=a;

Console.WriteLine("El valor de a: " + a);

Console.WriteLine("El valor de b: " + b); */


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