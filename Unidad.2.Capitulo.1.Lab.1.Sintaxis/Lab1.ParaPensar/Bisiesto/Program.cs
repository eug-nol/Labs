Console.WriteLine("Ingrese un año");
int anio = Int32.Parse(Console.ReadLine());

if (anio % 100 == 0)
{
    if (anio % 400 == 0) Console.WriteLine("El año ingresado es bisiesto.");
    else Console.WriteLine("El año ingresado no es bisiesto.");
}
else if (anio % 4 == 0) Console.WriteLine("El año ingresado es bisiesto.");
else Console.WriteLine("El año ingresado no es bisiesto.");