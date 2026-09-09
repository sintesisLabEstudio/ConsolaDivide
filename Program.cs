ConsConsole.WriteLine("PROGRAMA DIVISION DE 2 NUMEROS ");
Console.WriteLine("Ingrese el primer numero: ");
double num1 = double.Parse(Console.ReadLine());
Console.WriteLine("ingrese segundo numero: ");
double num2 = double.Parse(Console.ReadLine());
double resultado = num1 / num2;
if (num2 > 0)
{
    Console.WriteLine("El resultado de la division es: " + resultado);
}
else
{
    Console.WriteLine("Error: No se puede dividir entre cero.");
}
Console.WriteLine("El resultado de la division es: " + resultado);
Console.WriteLine("----------------------------------------");

