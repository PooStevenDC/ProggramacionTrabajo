using System;
using System.Collections.Generic;
using System.Text;

namespace Examen
{
    class ProductoSinDescuento: Producto, IProducto
    {

        public ProductoSinDescuento()
        {

        }

         


        // En este metodo que hereda de producto se esta aplicando el principio de Open/Closed
        // ya que porque el metodo Calcular Descuento hace que se calcule de una manera diferente en distintos tipos de productos
        // En este caso productos sin  descuento y productos con descuentos, es decir la clase producto no cambia queda cerrada,
        // En cambio las demas clases que heredan este metodo de producto, siguen abiertas y se pueden modificar segun los 
        // nuevos requerimientos
        public decimal CalcularDescuento()
        {
            return 100;
        }

        // ademas se hace poliforsismo lo cual hace que se establezca el 3 rincipio
        //"Sustitucion de liskov " en la cual esta heredando de la interfaz el metodo para asi hacer el proceso
    }
}
