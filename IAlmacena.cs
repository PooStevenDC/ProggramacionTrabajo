using System;
using System.Collections.Generic;
using System.Text;

namespace Examen
{
    interface IAlmacena
    {
        // Este principio es el quinto "inversion de dependencia  se crea la interfaz Ialmacenar  y se crea un metodo que almacena
        //para heredarla   la clase GuardarCompra
        public void Save(Carrito carrito);
    }
}
