namespace ClasePersona
{
    public class Persona
    {
        private string _nombre;
        private string _apellido;
        private int _edad;
        private int _dni;

        public Persona()
        {
            Console.Write("Nombre: ");
            Nombre = Console.ReadLine();
            Console.Write("Apellido: ");
            Apellido = Console.ReadLine();
            Console.Write("Edad: ");
            Edad = Convert.ToInt32(Console.ReadLine());
            Console.Write("DNI: ");
            DNI = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Se ha creado el objeto.");
        }

        public string Nombre { get { return _nombre; } set { _nombre = value; } }
        public string Apellido { get { return _apellido; } set { _apellido = value; } }
        public int Edad { get { return _edad; } set { _edad = value; } }
        public int DNI { get { return _dni; } set { _dni = value; } }

        public string GetFullName()
        {
            return Nombre + Apellido;
        }

        public int GetAge()
        {
            return Edad;
        }

        ~Persona()
        {
            Console.WriteLine("Se destruyó el objeto.");
        }
    }
}
