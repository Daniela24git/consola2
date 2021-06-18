using System;

namespace Fist_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digita tu nombre:");
            var nombre = Console.ReadLine();

            Console.WriteLine("Digita tu apellido:");
            var apellido = Console.ReadLine(); 
            
            Console.WriteLine("Ingresa tu direccion de domicilio:");
            var dirección = Console.ReadLine();

            Console.WriteLine("Ingresa tu estado civil:");
            var EstadoCivil = Console.ReadLine();

            Console.WriteLine("Digita tu edad:");
            int edad = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa tu peso:");
            int peso = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa tu altura:");
            double altura = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el lugar en que nacio:");
            var LugarNac = Console.ReadLine();

            Console.WriteLine("Ingresa tu pais:");
            var pais = Console.ReadLine();

            Console.WriteLine("Ingresa tu ciudad:");
            var ciudad = Console.ReadLine();
            DateTime fechaIngreso = DateTime.Now;

            Persona nombreP;
            nombreP = new Persona();

            Console.WriteLine("================DATOS PERSONALES====================");
            Console.WriteLine(nombreP.datosPersona(nombre, apellido, dirección));

            Console.WriteLine(nombreP.datosNum(edad, peso, altura));

            Console.WriteLine(nombreP.datosCiud(LugarNac, pais, ciudad));

            Console.WriteLine("Fecha Actual: " + fechaIngreso);
            Console.ReadKey();
        }
    }
}

    
          


