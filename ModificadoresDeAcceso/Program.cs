using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModificadoresDeAcceso
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();

            cliente.Nombre = "Carlos Encinas";
            cliente.Telefono = "6444205599";


            Console.WriteLine("Nombre:      " + cliente.Nombre);
            Console.WriteLine("Teléfono:    " + cliente.Telefono);

            try
            {
                cliente.Curp = "12345678912345678";
                Console.WriteLine("CURP:        " + cliente.Curp);

            } catch(Exception e)
            {
                Console.WriteLine("CURP:        " + "La CURP debe ser de 18 caracteres");
            }
            

            Console.ReadLine();
        
        }
    }
}
