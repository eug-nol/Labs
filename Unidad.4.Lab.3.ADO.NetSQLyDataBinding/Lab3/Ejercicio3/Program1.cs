using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Ejercicio3
{
    class Program1
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
            SqlCommand mycomando = new SqlCommand();
            mycomando.CommandText = "SELECT CustomerID, CompanyName FROM Customers";
            mycomando.Connection = myconn;

            //creamos un adaptador
            SqlDataAdapter myadap = new SqlDataAdapter("SELECT CustomerID, CompanyName FROM Customers", myconn);

            myconn.Open();
            //creamos el reader
            SqlDataReader mydr = mycomando.ExecuteReader();
            dtEmpresas.Load(mydr);
            myconn.Close();

            Console.WriteLine("Listado de Empresas: ");
            foreach (DataRow rowEmpresa in dtEmpresas.Rows)
            {
                string idempresa = rowEmpresa["CustomerID"].ToString();
                string nombreempresa = rowEmpresa["Companyname"].ToString();
                Console.WriteLine(idempresa + " - " + nombreempresa);
            }
            Console.ReadLine();
        }
    }
}
