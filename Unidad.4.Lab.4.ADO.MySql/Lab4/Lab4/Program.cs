using Lab4;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace Lab02
{
    class Program
    {

        static void Main(string[] args)
        {
            ContactosMySQL manejadorMySQL;
            manejadorMySQL = new ContactosMySQL();
            manejadorMySQL.listar();
            menu(manejadorMySQL);
        }

        static void menu(ContactosMySQL manejadorMySQL)
        {
            string rta = "";
            do
            {
                Console.WriteLine("1 - Listar");
                Console.WriteLine("2 - Agregar");
                Console.WriteLine("3 - Modificar");
                Console.WriteLine("4 - Eliminar");
                Console.WriteLine("5 - Guardar Cambios");
                Console.WriteLine("6 - Salir");
                rta = Console.ReadLine();
                switch (rta)
                {
                    case "1":
                        manejadorMySQL.listar();
                        break;
                    case "2":
                        manejadorMySQL.nuevaFila();
                        break;
                    case "3":
                        manejadorMySQL.editarFila();
                        break;
                    case "4":
                        manejadorMySQL.eliminarFila();
                        break;
                    case "5":
                        manejadorMySQL.aplicaCambios();
                        break;
                    default:
                        break;
                }
            } while (rta != "6");
        }
    }
}




// Anteriormente sin DataAdapter
//namespace Lab4
//{
//    class Program
//    {
//        static void Main (string[] args)
//        {
//            ContactosMySQL contacto = new ContactosMySQL();
//            contacto.listar();
//            menu(contacto);
//        }

//        static void menu(Contactos contacto)
//        {
//            string rta = "";
//            do
//            {
//                Console.WriteLine("1 - Listar");
//                Console.WriteLine("2 - Agregar");
//                Console.WriteLine("3 - Modificar");
//                Console.WriteLine("4 - Eliminar");
//                Console.WriteLine("5 - Guardar cambios");
//                Console.WriteLine("6 - Salir");
//                rta = Console.ReadLine();
//                switch (rta)
//                {
//                    case "1";
//                        contacto.listar();
//                        break;
//                    case "2":
//                        contacto.nuevaFila();
//                        break;
//                    case "3":
//                        contacto.editarFila();
//                        break;
//                    case "4":
//                        contacto.eliminarFila();
//                        break;
//                    case "5":
//                        contacto.aplicaCambios();
//                        break;
//                    default:
//                        break;
//                }
//            } while (rta != "6");
//        }
//    }
//}