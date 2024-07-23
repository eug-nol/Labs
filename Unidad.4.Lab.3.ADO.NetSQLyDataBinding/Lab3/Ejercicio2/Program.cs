using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            dsUniversidad miUniversidad = new dsUniversidad();

            dsUniversidad.dtAlumnosDataTable dtAlumnos = new dsUniversidad.dtAlumnosDataTable();
            dsUniversidad.dtCursosDataTable dtCursos = new dsUniversidad.dtCursosDataTable();
            dsUniversidad.dtAlumnosRow rowAlumno = dtAlumnos.NewdtAlumnosRow();

            rowAlumno.Apellido = "Perez";
            rowAlumno.Nombre = "Juan";
            dtAlumnos.AdddtAlumnosRow(rowAlumno);

            dsUniversidad.dtCursosRow rowCurso = dtCursos.NewdtCursosRow();
            rowCurso.Curso = "Informatica";
            dtCursos.AdddtCursosRow(rowCurso);

            dsUniversidad.dtAlumnos_CursosDataTable dtAlumnos_Cursos = new dsUniversidad.dtAlumnos_CursosDataTable();

            dsUniversidad.dtAlumnos_CursosRow rowAlumnos_Cursos = dtAlumnos_Cursos.NewdtAlumnos_CursosRow();

            dtAlumnos_Cursos.AdddtAlumnos_CursosRow(rowAlumno, rowCurso);

            rowAlumno = dtAlumnos.NewdtAlumnosRow();
            rowAlumno.Nombre = "Marcelo";
            rowAlumno.Apellido = "Perez";
            dtAlumnos.AdddtAlumnosRow(rowAlumno);

            dtAlumnos_Cursos.AdddtAlumnos_CursosRow(rowAlumno, rowCurso);
        }
    }
}
