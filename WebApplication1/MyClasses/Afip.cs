using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//Voy a usar la interfaz para poder cambiar provider de afip
using WebApplication1.Interfaces;

namespace WebApplication1.MyClasses {
    public class Afip {
        // Aca el metodo tendria que recibir un provider tipado, por si tengo mas clases que usen el metodo
        //public decimal CalcImpGanancias(Client c) {
        //    int porcentaje = 30;
        //    decimal ganancia = c.ObtenerGanancias();
        //    return ganancia * porcentaje;
        //}
        //public decimal CalcImpGanancias(Empleado e) {
        //    decimal ganancias = e.ObtenerGanancias();
        //    if (ganancias < 30000 * 12) {
        //        return 0;
        //    }
        //    return (ganancias - (30000 * 12)) * 3 / 100;
        //}

        //Metodo con provider tipado para reutilizacion
        public decimal CalcRecaudacionTtl(List<InterfaceGanancias> listaProvider) {
            decimal total = 0;
            foreach (var p in listaProvider) {
                total += p.CalcularGanancias();
            }
            return total;
        }
    }
}