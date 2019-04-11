using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

//Para agregar libreria de clases, References -> click derecho, agregar referencias de la libreria creada
using ClassLibrary1;
//Siempre chequear los namespaces, se enlazan con using 
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CalculadoraController : Controller
    {
        // GET: Calculadora
        public ActionResult Index()
        {
            return View();
        }

        //Sobrecargar el metodo para mostrar primero la pagina sin datos y luego con el post a la mismapag
        public ActionResult Suma() {
            return View();
        }
        [HttpPost]
        public ActionResult Suma(string num1, string num2)
        {
            int res = Calculadora.Sumar(num1, num2);
            ViewBag.SumaRes = res;
            return View();
        }

        //funciona sin sobrecargar el metodo, validando si los parametros son nulos
        //public ActionResult Resta(string num1, string num2) {
        //    if (num1 != null && num2 != null) {
        //        int res = Calculadora.Restar(num1, num2);
        //        ViewBag.RestaRes = res;
        //    }
        //    return View();
        //}

        //Action Resta con binding automatico a traves del model
        public ActionResult Resta(CalculadoraModel model) {
            int R = model.Num1 + model.Num2;
            model.Result = R;
            //la vista es TIPADA
            return View(model);
        }
    }
}