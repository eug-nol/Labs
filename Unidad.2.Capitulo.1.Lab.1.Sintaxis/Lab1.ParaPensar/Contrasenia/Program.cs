int intentos = 0;
string clave;
string claveReal = "hola123";

while (intentos < 4)
{
    intentos++;
    Console.Write("Ingrese clave: ");
    clave = Console.ReadLine();
    if (clave != claveReal) Console.WriteLine("Clave incorrecta");
    else
    {
        Console.WriteLine("Clave correcta");
        break;
    }
}