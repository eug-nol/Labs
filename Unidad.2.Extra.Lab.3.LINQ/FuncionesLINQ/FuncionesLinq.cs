using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FuncionesLINQ
{
    public class FuncionesLinq
    {
        public IEnumerable<string> ObtenerProvinciasQueEmpiezanConDeterminadasLetras(ArrayList provincias)
        {
            var ProvinciasSyT = from string pro in provincias
                                where pro.StartsWith("S")
                                select pro;
            return ProvinciasSyT;
        }

        public IEnumerable<int> ObtenerNumerosMayoresA20(IEnumerable<int> numeros)
        {
            var mayoresA20 = from nro in numeros
                             where nro > 20
                             select nro;
            return mayoresA20;
        }

        public IEnumerable<int> ObtenerCodigoPostalDeCiudadesQueTenganEnSuNombreTresCarateresDeterminados(IEnumerable<Ciudad> ciudades, string ciudad)
        {
            var CodigosPostales = from ciud in ciudades
                                  where ciud.Nombre.Contains(ciudad)
                                  select ciud.CodigoPostal;
            return CodigosPostales;
        }

        public IEnumerable<Empleado> AgregarEmpleadoListaDevolviendolaOrdenadaPorSueldo(IEnumerable<Empleado> empleados, IEnumerable<Empleado> empleadosParaAgregar, string order)
        {
            var todosLosEmpleados = empleados
                .Select(e => new Empleado())
                .Concat(empleadosParaAgregar.
                Select(em => new Empleado()));

            if (order == "ASC")
            {
                var empleadosOrdenados = todosLosEmpleados
                .Select(e => new Empleado())
                .OrderBy(x => x.Sueldo);
            }
            else
            {
                var empleadosOrdenados = todosLosEmpleados
                .Select(e => new Empleado())
                .OrderByDescending(x => x.Sueldo);
            }

            return todosLosEmpleados;
        }
    }
}
