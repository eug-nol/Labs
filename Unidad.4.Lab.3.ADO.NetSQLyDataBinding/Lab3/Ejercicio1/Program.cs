using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataTable dtAlumnos = new DataTable();
            //DataRow rwAlumno = dtAlumnos.NewRow(); //se saca esta línea y se pone mas abajo

            //ID ALUMNO
            DataColumn colIDAlumno = new DataColumn("IDAlumno", typeof(int));
            colIDAlumno.ReadOnly = true;
            colIDAlumno.AutoIncrement = true;
            colIDAlumno.AutoIncrementSeed = 0; //empieza en cero
            colIDAlumno.AutoIncrementStep = 1; //se incrementa de a uno

            DataColumn dtColNombre = new DataColumn("Nombre", typeof(string));
            DataColumn dtColApellido = new DataColumn("Apellido", typeof(string));

            dtAlumnos.Columns.Add(dtColApellido);
            dtAlumnos.Columns.Add(dtColNombre);

            //se agrega tambien el ID Alumno
            dtAlumnos.Columns.Add(colIDAlumno);
            //queremos que esta sea la clave primaria, por lo tanto ponemos:
            dtAlumnos.PrimaryKey = new DataColumn[] { colIDAlumno };

            // aqui añadimos la línea datarow
            DataRow rwAlumno = dtAlumnos.NewRow();

            rwAlumno[dtColApellido] = "Perez";
            rwAlumno[dtColNombre] = "Juan";

            dtAlumnos.Rows.Add(rwAlumno);

            DataRow rwAlumno2 = dtAlumnos.NewRow();
            rwAlumno2[dtColApellido] = "Perez";
            rwAlumno2[dtColNombre] = "Marcelo";
            dtAlumnos.Rows.Add(rwAlumno2);



            //Console.WriteLine("Listado de Alumnos");
            //foreach (DataRow row in dtAlumnos.Rows)
            //{
            //    Console.WriteLine(row[dtColApellido].ToString() + ", " + row[dtColNombre].ToString());
            //}
            //Console.WriteLine();


            // DataTable Cursos
            DataTable dtCursos = new DataTable("Cursos");
            DataColumn colIDCurso = new DataColumn("IDCurso", typeof(int));
            DataColumn colCurso = new DataColumn("Curso", typeof(string));
            colIDCurso.AutoIncrement = true;
            colIDCurso.AutoIncrementSeed = 1;
            colIDCurso.AutoIncrementStep = 1;

            dtCursos.Columns.Add(colIDCurso);
            dtCursos.Columns.Add(colCurso);
            dtCursos.PrimaryKey = new DataColumn[] { colIDCurso };

            //agregamos un datarow
            DataRow rwCurso = dtCursos.NewRow();
            rwCurso[colCurso] = "Informática";
            dtCursos.Rows.Add(rwCurso);


            //agregamos ambos datatable a un dataset Universidad
            DataSet dsUniversidad = new DataSet();
            dsUniversidad.Tables.Add(dtCursos);
            dsUniversidad.Tables.Add(dtAlumnos);

            //creamos la tabla que va a unir a cursos con cada alumno
            DataTable dtAlumnos_Cursos = new DataTable("Alumnos_Cursos");
            DataColumn col_ac_IDAlumno = new DataColumn("IDAlumno", typeof(int));
            DataColumn col_ac_IDCurso = new DataColumn("IDCurso", typeof(int));
            dtAlumnos_Cursos.Columns.Add(col_ac_IDAlumno);
            dtAlumnos_Cursos.Columns.Add(col_ac_IDCurso);

            dsUniversidad.Tables.Add(dtAlumnos_Cursos);

            //relacionamos las tablas entre si
            DataRelation relAlumno_ac = new DataRelation("Alumno_Cursos", colIDAlumno, col_ac_IDAlumno);
            DataRelation relCurso_ac = new DataRelation("Curso_Alumno", colIDCurso, col_ac_IDCurso);
            dsUniversidad.Relations.Add(relAlumno_ac);
            dsUniversidad.Relations.Add(relCurso_ac);

            //relacionamos los alumnos con los cursos ya existentes
            DataRow rwAlumnos_Cursos = dtAlumnos_Cursos.NewRow();
            rwAlumnos_Cursos[col_ac_IDAlumno] = 0; //Juan Pérez
            rwAlumnos_Cursos[col_ac_IDCurso] = 1; //informática
            dtAlumnos_Cursos.Rows.Add(rwAlumnos_Cursos);

            rwAlumnos_Cursos = dtAlumnos_Cursos.NewRow();
            rwAlumnos_Cursos[col_ac_IDAlumno] = 1; //Marcelo Perez
            rwAlumnos_Cursos[col_ac_IDCurso] = 1; //informatica
            dtAlumnos_Cursos.Rows.Add(rwAlumnos_Cursos);


            Console.Write("Ingrese el nombre del curso: ");
            string materia = Console.ReadLine();
            Console.WriteLine("Listado de alumnos del curso " + materia);
            DataRow[] row_CursoInf = dtCursos.Select("Curso = '" + materia + "'");
            foreach(DataRow rowCu in row_CursoInf)
            {
                DataRow[] row_AlumnosInf = rowCu.GetChildRows(relCurso_ac);
                foreach (DataRow rowAl in row_AlumnosInf)
                {
                    Console.WriteLine(rowAl.GetParentRow(relAlumno_ac)[dtColApellido].ToString() + ", " + rowAl.GetParentRow(relAlumno_ac)[dtColNombre].ToString());
                }
            }
            Console.ReadLine();
        }
    }
}