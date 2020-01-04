using System;
using System.Collections.Generic;
using System.Text;

namespace Examen
{
    class Detalledelcarrito
    {
         public Detalledelcarrito()
         {
            
         }

        public  Producto ProductoCarrito { get; set; }
        public int Cantidad { get; set; }



        //En este principio que es el quinto " Inversion de dependencias" hace que se inviertan las dependencias para
        //que los objetos pasen o un constructor y la clase sera de forma aislada 
        private IAlmacena interface2;

        
        public void Comprar(Carrito carrito)
        {
            GuardarCompra gc = new GuardarCompra();
            gc.Save(carrito);
            
        }

        public void DetalleCarrito(IAlmacena interface2)
        {
            this.interface2 = interface2;

        }

        public void Compra(Carrito carrito)
        {
            this.interface2.Save(carrito);

        }
    } 
}
