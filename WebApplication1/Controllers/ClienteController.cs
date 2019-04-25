using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using WebApplication1.MyClasses;
using WebApplication1.MyServices;
using WebApplication1.Interfaces;

namespace WebApplication1.Controllers
{
    public class ClienteController: Controller {
        // GET: Cliente
        //-------------------------Mostrar todos-------------------------
        public ActionResult _MostrarTodos() {
            List<Client> listaClientes = ClienteService.ObtenerListaClientes();
            List<Empleado> listaEmpleados = EmpleadoService.ObtenerListaEmpleados();
            List<InterfaceGanancias> listaGanancias = new List<InterfaceGanancias>();
            Afip afip = new Afip();
            // TODO borar porque esta el alta del cliente
            //if (listaClientes.Count == 0) {
                Client c = new Client();
                c.Dni = "12345678";
                c.Name = "Cliente";
                c.Gastos = 50;
                c.Ventas = 100;
                c.Ganancias = c.ObtenerGanancias();
                ClienteService.Agregar(c);

                Empleado e = new Empleado();
                e.Legajo = "87654321";
                e.Name = "Empleado";
                e.Salario = 100;
                e.Ganancias = c.ObtenerGanancias();
                EmpleadoService.Agregar(e);

                listaGanancias.AddRange(listaEmpleados);
                listaGanancias.AddRange(listaClientes);
                decimal recaudTotal = afip.CalcRecaudacionTtl(listaGanancias);
            
                ViewBag.RecTotal = recaudTotal;
            //return View(listaClientes);
            return View(listaGanancias);
        }

        //-------------------------Mostrar 1-------------------------
        public ActionResult MostrarUnDato(string id) {
            Client c = ClienteService.Obtener(id);
            return View(c);
        }

        //-------------------------Agregar-------------------------
        public ActionResult AgregarDatos() {
            return View();
        }
        [HttpPost]
        public ActionResult AgregarDatos(Client c) {
            ClienteService.Agregar(c);
            //return Redirect("/Cliente/MostrarTodos");
            return RedirectToAction("MostrarTodos", "Cliente");
        }
        
        //-------------------------Editar-------------------------
        public ActionResult EditarDatos(string id) {
            Client c = ClienteService.Obtener(id);
            return View(c);
        }
        [HttpPost]
        public ActionResult EditarDatos(Client c) {
            ClienteService.Modificar(c);
            //return Redirect("/Cliente/MostrarTodos");
            return RedirectToAction("MostrarTodos", "Cliente");
        }

        //-------------------------Borrar-------------------------
        public ActionResult BorrarDatos(string id) {
            ClienteService.Borrar(id);
            return RedirectToAction("MostrarTodos", "Cliente");
        }

    }
}