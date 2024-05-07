using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdivinaElNumero
{
    public class Juego
    {
        private int _record;
        private bool _acerto;

        public bool Acerto {  get { return _acerto; } set {  _acerto = value; } }

        public void ComenzarJuego()
        {
            int record_actual = 0;
            Console.WriteLine("Adivina el número");
            Jugada jugada = PreguntarMaximo();
            Console.WriteLine();
            Acerto=PreguntarNumero(jugada);

            if (Acerto)
            {
                record_actual += 1;
                Console.WriteLine("¡Has adivinado!");
            }
            else
            {
                Console.WriteLine("¡Has errado!");
            }

            CompararRecord(record_actual);
            Continuar(jugada);
        }

        public void CompararRecord(int record_actual)
        {
            if (record_actual > _record)
            {
                Console.WriteLine("Has logrado un nuevo record: " + record_actual);
                _record = record_actual;
            }
        }

        public void Continuar(Jugada jugada)
        {
            Console.WriteLine("Intentos " + Convert.ToString(jugada.Intentos));
            Console.Write("¿Desea jugar otra vez? [S/N]");
            string opcion = Console.ReadLine();

            if (opcion == "s") 
            {
                ComenzarJuego(); 
            }
        }

        public Jugada PreguntarMaximo()
        {
            Console.Write("Ingrese el número máximo para generar los valores aleatorios: ");
            int maximo = Convert.ToInt32(Console.ReadLine());

            Jugada jugada_actual = new Jugada(maximo);
            Console.WriteLine("Número generado!");

            return jugada_actual;
        }

        public bool PreguntarNumero(Jugada jugada)
        {
            Console.Write("¿Cuál es el número? ");
            int nro = Convert.ToInt32(Console.ReadLine());

            bool acerto = jugada.Comparar(nro);
            return acerto;
        }
    }
}
