﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Interfaces;

namespace WebApplication1.MyClasses {
    public class Client:InterfaceGanancias {
        public string Name { get; set; }
        public string Dni { get; set; }
        //----------------------------------
        public decimal Gastos { get; set; }
        public decimal Ventas { get; set; }
        public decimal Ganancias { get; set; }
        public decimal Impuestos { get; set; }
        public decimal ObtenerGanancias() {
            return Ventas - Gastos;
        }
        public decimal CalcularGanancias() {
            int porcentaje = 30;
            decimal ganancia = ObtenerGanancias();
            return ganancia * porcentaje;
        }
    }
}