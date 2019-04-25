using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Interfaces;

namespace WebApplication1.MyClasses {
    public class Empleado:InterfaceGanancias {
        public string Legajo { get; set; }
        public string Name { get; set; }
        //----------------------------------
        public decimal Salario { get; set; }
        public decimal Ganancias { get; set; }
        public decimal Impuestos { get; set; }
        public decimal ObtenerGanancias() {
            return Salario * 12;
        }
        public decimal CalcularGanancias() {
            decimal ganancias = ObtenerGanancias();
            if (ganancias < 30000 * 12) {
                return 0;
            }
            return (ganancias - (30000 * 12)) * 3 / 100;
        }
    }
}