using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Lab4
{
    public class ContactosMySQL : Contactos
    {

        protected string connectionString
        {
            get
            {
                return "server=serverisi;database=net;uid=net;pwd=net;";
                // Un Connection String  es un string que tiene los datos necesarios para conectarse
                // a un origen de datos a través de una conexión
            }
        }
        public override DataTable getTabla()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlCommand cmdSelect = new MySqlCommand("select * from contactos", conn);

                // declaramos un reader, ya que necesitamos leer los datos ya existentes
                MySqlDataReader reader = cmdSelect.ExecuteReader();

                // creamos el objeto DataTable para almacenar lo que leemos con el reader y mostrarlo
                DataTable contactos = new DataTable();
                if (reader != null)
                {
                    contactos.Load(reader);
                }
                conn.Close();
                return contactos;
            }
        }

        public override void aplicaCambios()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                MySqlCommand cmdInsert = new MySqlCommand("insert into contactos" + "values(@id, @nombre, @apellido, @email, @telefono)", conn);
                cmdInsert.Parameters.Add("@id", MySqlDbType.Int32);
                cmdInsert.Parameters.Add("@nombre", MySqlDbType.VarChar);
                cmdInsert.Parameters.Add("@apellido", MySqlDbType.VarChar);
                cmdInsert.Parameters.Add("@email", MySqlDbType.VarChar);
                cmdInsert.Parameters.Add("@telefono", MySqlDbType.VarChar);

                MySqlCommand cmdUpdate = new MySqlCommand("update contactos set nombre=@nombre, apellido=@apellido,email=@email,telefono=@telefono where id=@id", conn);
                cmdUpdate.Parameters.Add("@nombre", MySqlDbType.VarChar);
                cmdUpdate.Parameters.Add("@apellido", MySqlDbType.VarChar);
                cmdUpdate.Parameters.Add("@email", MySqlDbType.VarChar);
                cmdUpdate.Parameters.Add("@telefono", MySqlDbType.VarChar);
                cmdUpdate.Parameters.Add("@id", MySqlDbType.Int32);

                MySqlCommand cmdDelete = new MySqlCommand("delete from contactos where id=@id", conn);
                cmdDelete.Parameters.Add("@id", MySqlDbType.Int32);

                DataTable filasNuevas = this.misContactos.GetChanges(DataRowState.Added);
                DataTable filasEditadas = this.misContactos.GetChanges(DataRowState.Modified);
                DataTable filasEliminadas = this.misContactos.GetChanges(DataRowState.Deleted);
                // buscamos cuales filas fueron agregadas, modificadas y eliminadas en la datatable misContactos

                conn.Open();
                //MySqlDataReader reader = cmdInsert.ExecuteReader();
                if (filasNuevas != null)
                {
                    foreach (DataRow row in filasNuevas.Rows)
                    {
                        cmdInsert.Parameters["@id"].Value = row["id"];
                        cmdInsert.Parameters["@nombre"].Value = row["nombre"];
                        cmdInsert.Parameters["@apellido"].Value = row["apellido"];
                        cmdInsert.Parameters["@email"].Value = row["email"];
                        cmdInsert.Parameters["@telefono"].Value = row["telefono"];
                        cmdInsert.ExecuteNonQuery();
                    }
                }

                if (filasEditadas != null)
                {
                    foreach(DataRow row in filasEditadas.Rows)
                    {
                        cmdUpdate.Parameters["@nombre"].Value = row["nombre"];
                        cmdUpdate.Parameters["@apellido"].Value = row["apellido"];
                        cmdUpdate.Parameters["@email"].Value = row["email"];
                        cmdUpdate.Parameters["@telefono"].Value = row["telefono"];
                        cmdUpdate.Parameters["@id"].Value = row["id"];
                        cmdUpdate.ExecuteNonQuery();
                    }
                }

                if (filasEliminadas != null)
                {
                    foreach(DataRow row in filasEliminadas.Rows)
                    {
                        cmdDelete.Parameters["@id"].Value = row["id"];
                        cmdDelete.ExecuteNonQuery();
                    }
                }

                conn.Close();
                this.misContactos.AcceptChanges();
            }
        }
    }
}
