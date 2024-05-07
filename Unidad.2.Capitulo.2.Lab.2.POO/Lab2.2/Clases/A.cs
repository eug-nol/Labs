using System;

namespace Clases
{
    public class A
    {
        string NombreInstancia;

        public A() { NombreInstancia = "Instancia sin nombre"; }
        public A(string nuevoNombreInstancia) { NombreInstancia = nuevoNombreInstancia; }

        public void MostrarNombre() { Console.WriteLine(NombreInstancia); }

        public void M1() { Console.WriteLine("Se invocó a M1"); }
        public void M2() { Console.WriteLine("Se invocó a M2"); }
        public void M3() { Console.WriteLine("Se invocó a M3"); }
    }
}