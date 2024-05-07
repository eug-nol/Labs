namespace Geometria
{
    public class Circulo
    {
        private int m_radio;

        public int Radio
        {
            get => m_radio;
            set => m_radio = value;
        }

        public void CalcularPerimetro()
        {
            double perimetro = 2 * Math.PI * m_radio;
            Console.WriteLine(perimetro);
        }

        public void CalcularSuperficie()
        {
            double area = Math.PI * m_radio * m_radio;
            Console.WriteLine(area);
        }
    }


}
