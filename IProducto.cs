using System;
using System.Collections.Generic;
using System.Text;

namespace Examen
{
    interface IProducto
    {

        // Aqui se aplica el tercer principio "Sustitucion de liskov " donde se crea el metodo, el cual va ah herenciar 
        //  a los distintos tipos de productos con descuento y sin descuento lo cual hara que tenga distintos resultados

        //Se sobre escribe el metodo calcular descuento
        // y se implementa una funcionalidad en la clase hija
        decimal CalcularDescuento();
    }
}
