using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.Interfaces {
    // se puede hacer publica la interfaz para usarla en el exterior
    // buena practica -> hacer todo privado, y pasar a publico una vez que se necesite

    public interface InterfaceGanancias {
        string Name { get; set; }
        decimal Ganancias { get; set; }
        decimal Impuestos { get; set; }
        decimal CalcularGanancias();
    }
}
