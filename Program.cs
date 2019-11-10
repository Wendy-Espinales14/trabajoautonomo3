using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Channels;
using autonomo3.clases;
namespace autonomo3
{
    class Program
    {
        static void Main(string[] args)
        {


            cliente Cliente = new cliente();
                        Console.WriteLine("apellidos del cliente: ");
                        Cliente.Apellidos = Console.ReadLine();
                        Console.WriteLine(" nombres del cliente: ");
                        Cliente.Nombres = Console.ReadLine();
                        Console.WriteLine(" La cédula de identidad: ");
                        Cliente.Cedula = int.Parse(Console.ReadLine());
                        Console.WriteLine(" dirección domiciliaria: ");
                        Cliente.Apellidos = Console.ReadLine();


                        gasolina Gasolina = new  gasolina();
                        Console.WriteLine(" Ingrese el tipo de gasolina que desea: ");
                        Gasolina.Tipo = Console.ReadLine();
                        Console.WriteLine(" Ingrese la canntidad de galones que desea: ");
                        Gasolina.Cantidadgalones = double.Parse(Console.ReadLine());
                        Console.WriteLine(" El precio por galón es: " + Gasolina.Precioventa);

                        Console.WriteLine(" subtotal factura--->>: " + Gasolina.Subtotal);

                        Console.WriteLine(" precio IVA------>>>> :" + Gasolina.Iva);

                        Console.WriteLine(" total final ---->>>> : " + Gasolina.Total);
            Console.ReadKey();

        }
        
     }
 }
       
