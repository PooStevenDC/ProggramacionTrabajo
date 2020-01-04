using System;
using System.Collections.Generic;
using System.Text;

namespace Examen
{
    class  Impresora
    {
        
        public Impresora()
        {
            ListaClientes = new List<Cliente>();
        }


        public List<Cliente> ListaClientes { get; set; }

        //En esta clase se establece el principio de resonsabilidad,
        // debido a que esta clase se responsabiliza solamente de imprimir los datos del cliente 
        // y no se implementa otros procesos,

        public void ImprimirDatosCliente(Cliente cliente)
        {

            // Console.WriteLine(cliente.Apellidos + cliente.Nombres);

            //return cliente.Nombres + " " + cliente.Apellidos;

        }

        //Si se quiere agregar cliente a lista se hace este metodo se lo llama en el program y se imprimen los datos
        //por pantalla


        public void ImprimirlistadoCliente()
        {
            Console.WriteLine("Lista de clientes");
            Console.WriteLine("Nombre\tApellido\tCedula\tEmail\tContraseña\tCiudad \tFecha A");
            foreach (var item in this.ListaClientes)
            {
               Console.WriteLine("{0}\t{1}\t\t{2}\t{3}\t{4}\t{5}\t{6}",
               item.Nombres,item.Apellido,item.NumeroCedula,item.Email,item.Contrasenia,item.CiudadDeFacturacion,item.FechaActual);
            }
        }
    }
}

