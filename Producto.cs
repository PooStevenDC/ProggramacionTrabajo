using System;
using System.Collections.Generic;
using System.Text;

namespace Examen
{

    //Clase se convierte en abstracta, no se pueden crear instancias de esta clase
    public class Producto
    {
            public int Codigo { get; set; }

            public string Descripcion { get; set; }

            public decimal Precio { get; set; }
    }

}

