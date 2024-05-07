using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geometria
{
    public class Poligono
    {
        private int m_base;
        private int m_altura;

        public int Base
        {
            get => m_base;
            set => m_base = value;
        }

        public int Altura
        {
            get => m_altura;
            set => m_altura = value;
        }

        public void CalcularPerimetro()
        {
            int perimetro = Base * 2 + Altura * 2;
            Console.WriteLine(perimetro);
        }

        public void CalcularSuperficie()
        {
            float area = Base * Altura;
            Console.WriteLine(area);
        }
    }

    public class Rectangulo:Poligono
    {

    }

    public class Cuadrado:Rectangulo
    {

    }
}