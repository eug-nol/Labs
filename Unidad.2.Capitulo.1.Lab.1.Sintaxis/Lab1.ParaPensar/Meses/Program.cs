using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un mes del año: ");
            string mes = Console.ReadLine();
            int nro;

            switch (mes.ToLower())
            {
                case "enero":
                    nro = (int)ListaMeses.Enero; break;
                case "febrero":
                    nro = (int)ListaMeses.Febrero; break;
                case "marzo":
                    nro = (int)ListaMeses.Marzo; break;
                case "abril":
                    nro = (int)ListaMeses.Abril; break;
                case "mayo":
                    nro = (int)ListaMeses.Mayo; break;
                case "junio":
                    nro = (int)ListaMeses.Junio; break;
                case "julio":
                    nro = (int)ListaMeses.Julio; break;
                case "agosto":
                    nro = (int)ListaMeses.Agosto; break;
                case "septiembre":
                    nro = (int)ListaMeses.Septiembre; break;
                case "octubre":
                    nro = (int)ListaMeses.Octubre; break;
                case "noviembre":
                    nro = (int)ListaMeses.Noviembre; break;
                case "diciembre":
                    nro = (int)ListaMeses.Diciembre; break;
                default:
                    nro = 0; break;
            }

            Console.WriteLine($"{mes} + {nro}");
        }
    }
}
