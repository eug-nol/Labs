using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidad
{
    public class Alumno
    {
        int _Id;
        string _Nombre;
        string _Apellido;
        int _Legajo;
        string _Direccion;

        public Alumno(int id, string nombre, string apellido, int legajo, string direccion)
        {
            _Id = id;
            _Nombre = nombre;
            _Apellido = apellido;
            _Legajo = legajo;
            _Direccion = direccion;
        }

        public int Id { get { return _Id; } }
        public string Nombre { get { return _Nombre; } }
        public string Apellido { get { return _Apellido; } }
        public int Legajo { get { return _Legajo; } }
        public string Direccion { get { return _Direccion; } }
    }
}
