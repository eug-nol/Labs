using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Lab4
{
    public class Contactos
    {
        protected DataTable misContactos; // elemento DataTable que representará a nuestra tabla de datos
        public Contactos()
        {
            this.misContactos = this.getTabla(); // constructor que ejecuta el método inicializador getTabla
        }
        public virtual DataTable getTabla() // un método que nos devuelve el DataTable protegido
        {
            return new DataTable();
        }
        public virtual void aplicaCambios() // tienen el modificador virtual para que puedan ser modificados en las clases hijas
        {
            // no hay nada en la clase madre ya que la manera en que se apliquen los cambios se detallará en las clases hijas correspondientes
        }
        public void listar()
        {
            foreach (DataRow fila in this.misContactos.Rows)
            {
                // aclaramos que ignore las filas eliminadas
                if (fila.RowState == DataRowState.Deleted)
                {
                    foreach (DataColumn col in this.misContactos.Columns)
                    {
                        Console.WriteLine("{0}: {1}", col.ColumnName, fila[col]);
                    }
                    Console.WriteLine();
                }
            }
        }
        public void nuevaFila()
        {
            DataRow fila = this.misContactos.NewRow();
            foreach (DataColumn col in this.misContactos.Columns)
            {
                Console.Write("Ingresa {0}: ", col.ColumnName);
                fila[col] = Console.ReadLine();
            }
            this.misContactos.Rows.Add(fila); // se añade la nueva fila
        }
        public void editarFila()
        {
            Console.WriteLine("Ingrese el número de fila a editar: ");
            int nroFila = int.Parse(Console.ReadLine());
            DataRow fila = this.misContactos.Rows[nroFila - 1];
            for (int nroCol = 1; nroCol < this.misContactos.Columns.Count; nroCol++)
            {
                DataColumn col = this.misContactos.Columns[nroCol];
                Console.Write("Ingrese {0}: ", col.ColumnName);
                fila[col] = Console.ReadLine();
            }
        }
        public void eliminarFila()
        {
            Console.WriteLine("Ingrese el número de fila a eliminar: ");
            int fila = int.Parse(Console.ReadLine());
            this.misContactos.Rows[fila-1].Delete();
        }
    }
}
