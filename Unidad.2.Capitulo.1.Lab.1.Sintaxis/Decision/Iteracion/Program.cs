int cantIteraciones;
cantIteraciones = 5;

string[] arreglo;
arreglo = new string[cantIteraciones];

Console.WriteLine("Ingrese cadenas para el arreglo.");

for (int i = 0; i < cantIteraciones; i++)
{
    arreglo[i] = Console.ReadLine();
};

for (int i = cantIteraciones-1; i >= 0; i--)
{
    Console.WriteLine(arreglo[i]);
}
