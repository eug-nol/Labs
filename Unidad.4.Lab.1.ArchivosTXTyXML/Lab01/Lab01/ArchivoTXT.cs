﻿using System.IO;

leer();
Console.ReadKey();
escribir();
Console.ReadKey();
leer();
Console.ReadKey();

static void escribir()
{
    StreamWriter escritor = File.AppendText("agenda.txt");
    Console.WriteLine("Ingrese nuevo contacto");
    string rta = "S";
    while (rta == "S")
    {
        Console.Write("Ingrese nombre: ");
        string nombre = Console.ReadLine();
        Console.WriteLine();
        Console.Write("Ingrese apellido: ");
        string apellido = Console.ReadLine();
        Console.WriteLine();
        Console.Write("Ingrese e-mail: ");
        string email = Console.ReadLine();
        Console.WriteLine();
        Console.Write("Ingrese telefono: ");
        string telefono = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine();

        escritor.WriteLine(nombre + ";" + apellido + ";" + email + ";" + telefono);

        Console.Write("¿Desea ingresar otro contacto? (S/N)");
        rta = Console.ReadLine();
    }
    escritor.Close();
}

static void leer()
{
    StreamReader lector = File.OpenText("agenda.txt");
    string linea;
    Console.WriteLine("Nombre\tApellido\te-mail\t\t\tTelefono");
    do
    {
        linea = lector.ReadLine();
        if (linea != null)
        {
            string[] valores = linea.Split(";");
            Console.WriteLine("{0}\t{1}\t{2}\t{3}", valores[0], valores[1], valores[2], valores[3]);
        }
    }
    while (linea != null);
    lector.Close();
}


//FileStream lector = new FileStream("agenda.txt", FileMode.Open, FileAccess.Read, FileShare.Read);
//while (lector.Length > lector.Position)
//{
//    Console.Write((char)lector.ReadByte());
//}
//lector.Close();
//Console.ReadKey();


//StreamReader lector = File.OpenText("agenda.txt");
//string linea;
//do
//{
//    linea = lector.ReadLine();
//    if (linea != null )
//    {
//        Console.WriteLine(linea);
//    }
//}
//while (linea != null);
//lector.Close();
//Console.ReadKey();
