using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AdivinaElNumero
{
    public class Jugada
    {
        int _numero;
        private int _intentos;
        private bool _adivino;

        public int Numero { get { return _numero; } set { _numero = value; } }
        public int Intentos { get { return _intentos; } set { _numero = value; } }
        public bool Adivino { get { return _adivino; } set { _adivino = value; } }

        public bool Comparar(int nro)
        {
            if (Numero == nro) { Adivino = true; }
            else 
            { 
                Adivino = false;
                Intentos += 1;
            }

            return Adivino;
        }

        public Jugada(int maxNumero)
        {
            Random rnd = new Random();
            Numero = rnd.Next(maxNumero);
        }

    }
}
