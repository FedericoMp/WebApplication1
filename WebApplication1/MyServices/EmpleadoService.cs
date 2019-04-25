using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.MyClasses;

namespace WebApplication1.MyServices {
    public class EmpleadoService {
        private static List<Empleado> listaEmpleados = new List<Empleado>();
        //Retornar la lista de clientes generada
        public static List<Empleado> ObtenerListaEmpleados() {
            return listaEmpleados;
        }
        public static void Agregar(Empleado e) {
            listaEmpleados.Add(e);
        }
    }
}