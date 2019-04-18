﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using WebApplication1.MyClasses;
using WebApplication1.MyServices;

namespace WebApplication1.Controllers
{
    public class ClienteController: Controller {
        // GET: Cliente
        //-------------------------Mostrar todos-------------------------
        public ActionResult MostrarTodos() {
            List<Client> listaClientes = ClienteService.ObtenerListaClientes();
            // TODO borar porque esta el alta del cliente
            if (listaClientes.Count == 0) {
                Client c = new Client();
                c.Dni = "12345678";
                c.Name = "Test";
                //Agregamos a la lista
                ClienteService.Agregar(c);
            }
            return View(listaClientes);
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