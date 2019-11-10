using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Channels;

namespace autonomo3.clases
{
    public class gasolina
    {
        private string tipo;

        public string Tipo
        {
            get { return tipo; }
            set {tipo = value; }
        }
        private double cantidadgalones;

        public double Cantidadgalones
        {
            get { return cantidadgalones; }
            set { cantidadgalones = value; }
        }
        private double precioventa;
        public double Precioventa
        {
           
            get
            {
                
                    if (Tipo == " Extra ")
                    {
                       precioventa= 1.50 ;
                    }
                    if(Tipo == " Super ")
                    {
                        precioventa= 2.00;
                    }
                    return precioventa;
                }

        }
        private double subtotal;

        public double Subtotal
        {
            get {
                
                subtotal = (cantidadgalones * precioventa);
                
                
                
                return subtotal; 
            }
            
        }

        private double iva;

        public double Iva
        {
            get {

                iva = subtotal * 0.12;
                return iva; }
            
        }
        private double total;

        public double Total
        {
            get {

                total = subtotal + iva;
                
                return total; }
        }

    } 
}
      

   

