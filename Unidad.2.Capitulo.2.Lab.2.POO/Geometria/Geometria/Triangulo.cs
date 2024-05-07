using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geometria
{
    public class Triangulo
    {
        private int m_base;
        private int m_altura;
        private int m_lado1;
        private int m_lado2;
        private int m_lado3;

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

        public int Lado1
        {
            get => m_lado1;
            set => m_lado1 = value;
        }

        public int Lado2
        {
            get => m_lado2;
            set => m_lado2 = value;
        }

        public int Lado3
        {
            get => m_lado3;
            set => m_lado3 = value;
        }

        public void CalcularPerimetro()
        {
            int perimetro = Lado1 + Lado2 + Lado3;
            Console.WriteLine(perimetro);
        }

        public void CalcularSuperficie()
        {
            float area = (Base * Altura) / 2;
            Console.WriteLine(area);
        }
    }
}