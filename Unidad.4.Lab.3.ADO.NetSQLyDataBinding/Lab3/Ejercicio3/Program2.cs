using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Ejercicio3
{
    class Program2
    {
        static void Main(string[] args)
        {
            DataTable dtEmpresas = new DataTable();
            //podemos crear las columnas como antes
            //DataColumn colCustomerID = new DataColumn("CustomerID", typeof(int));
            //DataColumn colCompanyName = new DataColumn("CompanyName", typeof(string));
            //o bien
            dtEmpresas.Columns.Add("CustomerID", typeof(int));
            dtEmpresas.Columns.Add("CompanyName", typeof(string));

            // Creamos un objeto SQLConnection
            SqlConnection myconn = new SqlConnection();
            myconn.ConnectionString = "Data Source =LOCALHOST;Initial Catalog=Northwind;User ID=sa;Pwd=123";

            SqlDataAdapter myadap = new SqlDataAdapter("SELECT CustomerID, CompanyName FROM Customers", myconn);
            myconn.Open();
            myadap.Fill(dtEmpresas);
            myconn.Close();

            Console.WriteLine("Listado de Empresas: ");
            foreach (DataRow rowEmpresa in dtEmpresas.Rows)
            {
                string idempresa = rowEmpresa["CustomerID"].ToString();
                string nombreempresa = rowEmpresa["Companyname"].ToString();
                Console.WriteLine(idempresa + " - " + nombreempresa);
            }
            Console.ReadLine();

            //Para realizar cambios en un datatable y volcarlos a la base de datos
            //indicamos el CustomID a modificar
            Console.Write("Escriba el CustomerID que desea modificar: ");
            string custid = Console.ReadLine();

            //buscamos el customerID
            DataRow[] rwempresas = dtEmpresas.Select("CustomerID = '" + custid + "'");
            if (rwempresas.Length != 1)
            {
                Console.WriteLine("CustomerID no encontrado");
                Console.ReadLine();
                return;
            }

            //si lo encontramos
            DataRow rowMiEmpresa = rwempresas[0];
            string nombreactual = rowMiEmpresa["CompanyName"].ToString();
            Console.WriteLine("Nombre actual de la empresa: " + nombreactual);
            Console.Write("Escriba el nuevo nombre: ");
            string nuevonombre = Console.ReadLine();

            rowMiEmpresa.BeginEdit();
            rowMiEmpresa["CompanyName"] = nuevonombre;
            rowMiEmpresa.EndEdit();

            SqlCommand updcommand = new SqlCommand();
            updcommand.Connection = myconn;
            updcommand.CommandText = "UPDATE Customers SET CompanyName = @CompanyName WHERE CustomerID = @CustomerID";
            updcommand.Parameters.Add("@CompanyName", SqlDbType.NVarChar, 50, "CompanyName");
            updcommand.Parameters.Add("@CustomerID", SqlDbType.NVarChar, 5, "CustomerID");

            myadap.UpdateCommand = updcommand;
            myadap.Update(dtEmpresas);
        }
    }
}
