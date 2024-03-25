namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            string valor1 = "Este es el valor 1";
            int valor2 = 5;
            //string valor3 = valor2;
            string valor3 = valor1;
            Console.WriteLine(valor1);
            Console.WriteLine(valor2);
            Console.WriteLine(valor3);

            Console.WriteLine();
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }
}