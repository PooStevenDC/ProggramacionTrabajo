using System;
using System.Collections.Generic;
using System.Text;

namespace Examen
{
    class Carrito  
    {
        

        //  El cuarto principio no se aplica el  cual es de segregacion de interfaces debido a que en esta clase 
        // se hacen todos los calculos de la factura y no hay necesidad de aplicar interfaces para heredar metodos 
        // y hacer procedimientos en cuanto al descuento subtotal total, es decir aqui  se hacen esos calculos sin necesidad
        // de aplicar ese principio de segregacion de interfaces por tanto seria una responsabiidad unica porque se hacen
        // todos los calculos de factura

        public decimal SubTotal { get; set; }
        public decimal Descuento{ get; set; }
        public decimal SubTotal2 { get; set; }
        public decimal Total{ get; set; }
        public decimal Iva { get; set; }
       
        public Carrito()
        {
            this.Detalle = new List<Detalledelcarrito>();
        }
        //public CabeceraCarrito Cabecera { get; set; }

        public List<Detalledelcarrito> Detalle { get; set; }

       
        public void CalcularSubtotal()
        {
            decimal subtotal = 0;
            foreach (var item in this.Detalle)
            {
                subtotal = subtotal + (item.Cantidad * item.ProductoCarrito.Precio);
            }
            this.SubTotal = subtotal;
        }
        public void CalcularDescuento()
        {
            if (this.SubTotal > 100)
            {
                this.Descuento = this.SubTotal * 0.05M;
            }   
            else
            {
                this.Descuento = 0;
            }
        }

        public void CalcularSubtotal2()
        {
            decimal subtotal2 = 0;
            foreach (var item in this.Detalle)
            {
                subtotal2 = SubTotal - Descuento ;
            }
            this.SubTotal2 = subtotal2;

        }

        public void CalcularIva()
        {
            
            this.Iva = (this.SubTotal - this.Descuento) * 0.12M;
        }

        public void CalcularTotal()
        {
            this.Total =( this.SubTotal - this.Descuento )+this.Iva;
        }
        
    }
}
