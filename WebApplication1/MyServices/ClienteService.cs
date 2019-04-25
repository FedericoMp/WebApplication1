using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using WebApplication1.MyClasses;

namespace WebApplication1.MyServices {
    public class ClienteService {
        //creacion de obj estaticos
        public static Client MostrarCliente(string name) {
            Client C = new Client {
                Name = name
            };
            return C;
        }
        public static List<Client> MostrarListaClientes() {
            List<Client> CList = new List<Client> {
                                    new Client {
                                        Name = "cliente 1"
                                    },
                                    new Client {
                                        Name = "cliente 2"
                                    },
                                    new Client {
                                        Name = "cliente 3"
                                    }
                                };
            return CList;
        }

        //-----------------------------------------------------------------
        //Refactor de codigo

        // Genero mi estructura de datos
        private static List<Client> listaClientes = new List<Client>();
        //Retornar la lista de clientes generada
        public static List<Client> ObtenerListaClientes() {
            return listaClientes;
        }

        //Obtener todos los elementos de la lista
        public static Client Obtener(string dni) {
            //Traer el primero como valor por defecto, y hay una condicion; se puede concatenar con && o ||
            //Es como una especie de for, foreach c-> es un elemento
            return listaClientes.FirstOrDefault(c => c.Dni == dni);
        }

        public static void Modificar(Client c) {
            Borrar(c.Dni);
            listaClientes.Add(c);
        }

        public static void Borrar(string dni) {
            listaClientes.RemoveAll(c=> c.Dni == dni);
        }

        //Agregar los datos a la lista
        public static void Agregar(Client c) {
            listaClientes.Add(c);
        }


    }
}