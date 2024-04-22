Console.WriteLine("Ingrese una cadena.");
string inputTexto = Console.ReadLine();

//Exception

if (inputTexto != "")
{
    Console.WriteLine("Mostrar la frase ingresada: 1-En mayúsculas. 2-En minúsculas. 3-Cantidad de caracteres");
    ConsoleKeyInfo opcion = Console.ReadKey();

    if (opcion.Key == ConsoleKey.D1) Console.WriteLine("Texto ingresado en mayúsculas: " + inputTexto.ToUpper());

    else if (opcion.Key == ConsoleKey.D2) Console.WriteLine("Texto ingresado en minúsculas: " + inputTexto.ToLower());

    else if (opcion.Key == ConsoleKey.D3) Console.WriteLine("Cantidad de caracteres del texto ingresado: " + inputTexto.Length);
        
    else Console.WriteLine("Opción ingresada no es válida");

}
else Console.WriteLine("No se ingresó ningún caracter");