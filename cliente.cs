using System;
using System.Collections.Generic;
using System.Text;

namespace autonomo3.clases
{
   public class cliente
    {
        private string nombres;

        public string Nombres
        {
            get {
               
                    return nombres
                    ; }
            set { nombres = value; }
        }
        private string apellidos;

        public  string Apellidos
        {
            get {
               
                return apellidos; }
            set { apellidos = value; }
        }
        private int cedula;

        public int Cedula
        {
            get { return cedula; }
            set { cedula = value; }
        }
        private string direccion;

        public  string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }




    }
}
